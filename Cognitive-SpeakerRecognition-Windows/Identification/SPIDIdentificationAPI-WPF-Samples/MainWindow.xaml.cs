﻿// 
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.
// 
// Microsoft Cognitive Services (formerly Project Oxford): https://www.microsoft.com/cognitive-services
// 
// Microsoft Cognitive Services (formerly Project Oxford) GitHub:
// https://github.com/Microsoft/Cognitive-SpeakerRecognition-Windows
// 
// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 

using SampleUserControlLibrary;
using System.Windows;

namespace SPIDIdentificationAPI_WPF_Samples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Gets the sample scenario control
        /// </summary>
        public SampleScenarios ScenarioControl
        {
            get
            {
                return _scenariosControl;
            }
        }

        /// <summary>
        /// Constructor to initialize the Main Window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            _scenariosControl.SampleTitle = "Speaker Identification Sample";
            _scenariosControl.SampleScenarioList = new Scenario[]
            {
                new Scenario{ Title = "Enroll Speakers", PageClass = typeof(EnrollSpeakersPage)},
                new Scenario{ Title = "Identify File", PageClass = typeof(IdentifyFilePage)},
            };
            
            _scenariosControl.Disclaimer = string.Empty;

            _scenariosControl.ClearLog();
        }

        /// <summary>
        /// Writes a message in the status area
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Log(string message)
        {
            _scenariosControl.Log(message);
        }

        private void _scenariosControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
