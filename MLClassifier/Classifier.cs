﻿using MlClassifier;

namespace MLClassifier
{
    public static class Classifier
    {
        public static string Classify(string imagePath)
        {

            var imageBytes = File.ReadAllBytes(@$"{imagePath}");
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                ImageSource = imageBytes,
            };
            var predictionResult = MLModel1.Predict(sampleData);
            return predictionResult.PredictedLabel;
        }

    }
}
