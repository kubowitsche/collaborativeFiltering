// Databricks notebook source
// MAGIC %md
// MAGIC ### Citations
// MAGIC Thank you to GroupLense for allowing the usage of their MovieLense dataset.
// MAGIC 
// MAGIC F. Maxwell Harper and Joseph A. Konstan. 2015. The MovieLens Datasets: History and Context. ACM Transactions on Interactive Intelligent Systems (TiiS) 5, 4, Article 19 (December 2015), 19 pages. DOI=http://dx.doi.org/10.1145/2827872

// COMMAND ----------

// MAGIC %md
// MAGIC ### Load

// COMMAND ----------

val moviesRaw = sqlContext
  .read
  .format("csv")
  .option("header", "true")
  .load("/FileStore/tables/apnvcztj1487083615075/movies.csv")

display(moviesRaw)

// COMMAND ----------

val ratingsRaw = sqlContext
  .read
  .format("csv")
  .option("header", "true")
  .load("/FileStore/tables/cdyhtgfl1487083843782/ratings.csv")

display(ratingsRaw)

// COMMAND ----------

// MAGIC %md
// MAGIC ### Transform

// COMMAND ----------

import org.apache.spark.sql.functions._

val reviewItems = moviesRaw
  .withColumn("category", lit("movie"))
  .withColumn("description", lit("It's a good movie???"))
  .select($"movieId".alias("id"), $"title".alias("name"), $"description", $"category", $"genres".alias("subcategory"))

display(reviewItems)

// COMMAND ----------

val reviews = ratingsRaw
  .withColumn("text", lit("It IS a good movie!"))
  .select($"userId".alias("user_id"), $"movieId".alias("review_item_id"), $"rating", $"text")

display(reviews)

// COMMAND ----------

println(reviews.count())
println(reviewItems.count())

// COMMAND ----------

val users = reviews
  .select($"user_id")
  .distinct()
  .withColumn("name", lit("Malcolm Reynolds"))
  .sort($"user_id".asc)

display(users)

// COMMAND ----------

users.count()
