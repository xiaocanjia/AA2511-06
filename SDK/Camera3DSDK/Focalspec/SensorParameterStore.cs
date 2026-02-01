using System;
using System.Collections.Generic;
using System.Text;

namespace Camera3DSDK
{
    public class SensorParameterStore
    {
        /// <summary>
        /// Singleton instance.
        /// </summary>
        private static SensorParameterStore _instance;
        public static SensorParameterStore GetInstance() => _instance ?? (_instance = new SensorParameterStore());

        public class LayerParameter
        {
            public LayerParameter()
            {
                IntensityType = 0;
                MaxThickness = 0;
                MinThickness = 0;
                RefractiveIndex = 1;
            }
            public int IntensityType;
            public double MaxThickness;
            public double MinThickness;
            public double RefractiveIndex;
        }

        private SensorParameterStore()
        {
            Layers = new LayerParameter[10];
            for (int i = 0; i < Layers.Length; i++) { Layers[i] = new LayerParameter(); }

            MaxLedPulseWidth = 100;
            Freq = 300;
            IsAgcEnabled = false;
            AgcTargetIntensity = 80.0f;
            PulseDivider = 1;
            JumboFrameMtu = 9014;
            Current = 1.0;
            Gain = 1.0;
            GainHs = 2.0;
            FirLength = 16;
            AverFirLength = 16;
            DetectionFilter = 16;
            AverageIntensityFilter = 16;
            Threshold = 24;
            SensorWidth = 2048;
            MaxPointCount = 20000;
            HdrEnabled = false;
            HdrVLow2 = 33;
            HdrKp1Pos = 95;
        }

        public float LedPulseWidth { get; set; }
        public int MaxLedPulseWidth { get; set; }
        public int Freq { get; set; }
        public bool IsExternalPulsingEnabled { get; set; }
        public double AveragePixelWidth { get; set; }
        public double AveragePixelHeight { get; set; }
        public bool IsAgcEnabled { get; set; }
        public float AgcTargetIntensity { get; set; }
        public int PulseDivider { get; set; }
        public int JumboFrameMtu { get; set; }
        public double Current { get; set; }
        public double Gain { get; set; }
        public double GainHs { get; set; }
        public int TriggerSource { get; set; }
        public float LayerMinThickness { get; set; }
        public int FirLength { get; set; }
        public int AverFirLength { get; set; }
        public int DetectionFilter { get; set; }
        public int AverageIntensityFilter { get; set; }
        public int Threshold { get; set; }
        public int MaxPointCount { get; set; }
        public bool HdrEnabled { get; set; }
        public float HdrVLow2 { get; set; } = 114;
        public float HdrVLow3 { get; set; } = 116;
        public float HdrKp1Pos { get; set; } = 10;
        public float HdrKp2Pos { get; set; } = 25;
        public int SensorWidth { get; set; }
        public int XOffset { get; set; }
        public int SensorType { get; set; }
        public bool IsPeakEnabled { get; set; }
        public int NoiseRemoval { get; set; }
        public double AverageZFilterSize { get; set; }
        public double AverageIntensityFilterSize { get; set; }
        public int MedianZFilterSize { get; set; }
        public int MedianIntensityFilterSize { get; set; }
        public double ResampleLineXResolution { get; set; }
        public int PeakXFilter { get; set; }
        public int OffsetY { get; set; }
        public bool IsThicknessMode { get; set; }
        public double FillGapMax { get; set; }
        public bool IsTrimEdges { get; set; }
        public double ClusteringX { get; set; }
        public double ClusteringZ { get; set; }
        public double ClusterMin { get; set; }

        public LayerParameter[] Layers { get; set; }
    }
}
