wget https://archive.apache.org/dist/spark/spark-2.1.0/spark-2.1.0-bin-hadoop2.6.tgz
tar -xvf spark-2.1.0-bin-hadoop2.6.tgz -C /bin
echo "
export SPARK_HOME=/bin/spark
export PATH=$SPARK_HOME/bin:$PATH" >> ~/.profile
