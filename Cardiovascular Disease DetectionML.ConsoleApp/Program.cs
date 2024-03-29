// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.IO;
using System.Linq;
using Microsoft.ML;
using Cardiovascular_Disease_DetectionML.Model;

namespace Cardiovascular_Disease_DetectionML.ConsoleApp
{
    class Program
    {
        //Dataset to use for predictions 
        private const string DATA_FILEPATH = @"C:\Users\mhabi\Desktop\cardio_train.csv";

        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = CreateSingleDataSample(DATA_FILEPATH);

            // Make a single prediction on the sample data and print results
            ModelOutput predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Cardio with predicted Cardio from sample data...\n\n");
            Console.WriteLine($"id: {sampleData.Id}");
            Console.WriteLine($"age: {sampleData.Age}");
            Console.WriteLine($"gender: {sampleData.Gender}");
            Console.WriteLine($"height: {sampleData.Height}");
            Console.WriteLine($"weight: {sampleData.Weight}");
            Console.WriteLine($"ap_hi: {sampleData.Ap_hi}");
            Console.WriteLine($"ap_lo: {sampleData.Ap_lo}");
            Console.WriteLine($"cholesterol: {sampleData.Cholesterol}");
            Console.WriteLine($"gluc: {sampleData.Gluc}");
            Console.WriteLine($"smoke: {sampleData.Smoke}");
            Console.WriteLine($"alco: {sampleData.Alco}");
            Console.WriteLine($"active: {sampleData.Active}");
            Console.WriteLine($"\n\nActual Cardio: {sampleData.Cardio} \nPredicted Cardio: {predictionResult.Prediction}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }

        // Change this code to create your own sample data
        #region CreateSingleDataSample
        // Method to load single row of dataset to try a single prediction
        private static ModelInput CreateSingleDataSample(string dataFilePath)
        {
            // Create MLContext
            MLContext mlContext = new MLContext();

            // Load dataset
            IDataView dataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                                            path: dataFilePath,
                                            hasHeader: true,
                                            separatorChar: ';',
                                            allowQuoting: true,
                                            allowSparse: false);

            // Use first line of dataset as model input
            // You can replace this with new test data (hardcoded or from end-user application)
            ModelInput sampleForPrediction = mlContext.Data.CreateEnumerable<ModelInput>(dataView, false)
                                                                        .First();
            return sampleForPrediction;
        }
        #endregion
    }
}
