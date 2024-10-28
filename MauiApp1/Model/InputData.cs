using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Model
{
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
