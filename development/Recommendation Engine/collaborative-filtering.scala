// Databricks notebook source
import org.apache.spark.sql.types.{StructType, StructField, StringType, LongType, FloatType}

val scriptStartTime = System.currentTimeMillis().toDouble / 1000;

val reviewItemsSchema = StructType(
  StructField("review_item_id", LongType, false) ::
  StructField("name", StringType, false) ::
  StructField("description", StringType, false) ::
  StructField("category", StringType, false) ::
  StructField("subcategory", StringType, false) ::
  Nil) 

val reviewItems = sqlContext
  .read
  .format("csv")
  .option("header", "true")
  .schema(reviewItemsSchema)
  .load("/FileStore/tables/wl1ng6rt1487124319148/review_items.csv")
  .map(row => (row.getLong(0), row.getString(1).replaceAll("\"", ""), row.getString(2), row.getString(3), row.getString(4)))
  .toDF(reviewItemsSchema.fieldNames:_*)

display(reviewItems)

// COMMAND ----------

val reviewSchema = StructType(
  StructField("user_id", LongType, false) ::
  StructField("review_item_id", LongType, false) ::
  StructField("rating", FloatType, false) ::
  StructField("text", StringType, false) ::
  Nil) 

val reviews = sqlContext
  .read
  .format("csv")
  .option("header", "true")
  .schema(reviewSchema)
  .load("/FileStore/tables/tu12r4dg1487145058449/reviews.csv")

display(reviews)

// COMMAND ----------

val reviewsSplit = reviews.randomSplit(Array(0.7, 0.3))
val trainingReviews = reviewsSplit(0)
val testingReviews = reviewsSplit(1)

// COMMAND ----------

import org.apache.spark.ml.recommendation.ALS

val als = new ALS()
  .setUserCol("user_id")
  .setItemCol("review_item_id")
  .setRatingCol("rating")
  .setMaxIter(20)
  .setRank(10)
  .setRegParam(0.1)

val model = als.fit(trainingReviews)

val predictions = model.transform(testingReviews)

display(predictions)

val scriptEndTime = System.currentTimeMillis().toDouble / 1000;

// COMMAND ----------

val nUsers = reviews.select("user_id").distinct().count()
val nRecommendations = predictions.na.drop().count()

// COMMAND ----------

println(s"Full script execution time : %2.2f seconds".format(scriptEndTime - scriptStartTime))
println(s"Recommendations per User   : $nRecommendations/$nUsers = %2.2f".format(nRecommendations.toDouble / nUsers))

// COMMAND ----------

// MAGIC %md
// MAGIC ### View statistics

// COMMAND ----------

import org.apache.spark.ml.evaluation.RegressionEvaluator

val evaluator = new RegressionEvaluator()
  .setMetricName("rmse")
  .setLabelCol("rating")
  .setPredictionCol("prediction")

println(s"RMSE: ${evaluator.evaluate(predictions.na.drop())}")

// COMMAND ----------

// MAGIC %md
// MAGIC ### Prepare for export

// COMMAND ----------

val recommendations = predictions
  .na.drop(Array("prediction"))
  .select($"user_id", $"review_item_id", $"prediction".alias("rating"))

display(recommendations)
