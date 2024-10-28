using Microsoft.Maui.Controls;
using Microsoft.Maui;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;
using Plugin.Maui.Biometric;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private static MLContext mlContext = new MLContext();
        private static ITransformer trainedModel;
        private static PredictionEngine<InputData, Prediction> predEngine;

        public MainPage()
        {
            InitializeComponent();
        }


        private async void OnCaptureButtonClicked(object sender, EventArgs e)
        {
            // Biometric Authentication
            var authResult = await AuthenticateBiometrics();
            if (!authResult)
            {
                await DisplayAlert("Error", "Authentication failed!", "OK");
                return;
            }

            // Capture Photo
            var photo = await MediaPicker.CapturePhotoAsync();
            if (photo == null) return;

            using var stream = await photo.OpenReadAsync();
           // CapturedImage.Source = ImageSource.FromStream(() => stream);

            // Simulate extracting features from the image (for example purposes)
            var features = ExtractFeaturesFromImage(stream);
            var prediction = predEngine.Predict(features);
            await DisplayAlert("Prediction", $"Predicted Score: {string.Join(", ", prediction.Scores)}", "OK");
        }

        private async Task<bool> AuthenticateBiometrics()
        {
            try
            {
                var result = await BiometricAuthenticationService.Default.AuthenticateAsync(new AuthenticationRequest()
                {
                    Title="Please Authenticate to store in database",
                    NegativeText="Cancel Authentication"
                },CancellationToken.None);
                return result.Status==BiometricResponseStatus.Success;
            }
            catch (Exception)
            {
                return false; // Handle exceptions accordingly
            }
        }

        private InputData ExtractFeaturesFromImage(Stream imageStream)
        {
            // Implement your feature extraction logic here.
            // For example, you might use image processing to create feature vectors.
            return new InputData
            {
                Feature1 = 1.0f, // Placeholder value
                Feature2 = 2.0f  // Placeholder value
            };
        }
    }

    // Define your input and prediction classes
    public class InputData
    {
        public float Feature1 { get; set; }
        public float Feature2 { get; set; }
    }

    public class Prediction
    {
        [ColumnName("Score")]
        public float[] Scores { get; set; }
    }
}


