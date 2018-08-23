using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorTest
{
    public partial class Motor_test_data
    {
        public void ReCalculateOutputs()
        {


            System.Console.WriteLine("Calculating!");

            if (null != Motor)
            {
                OutputCatalogMotorWindingResistanceAt20CMin = Motor.PhToPhResistance * 0.96M;
                OutputCatalogMotorWindingResistanceAt20CMax = Motor.PhToPhResistance * 1.04M;
                if (null != InputMotorTemp)
                {
                    //OutputCatalogMotorWindingResistanceMinCorrected = Math.Round((decimal)(OutputCatalogMotorWindingResistanceAt20CMin * (236.4M + InputMotorTemp) / 256.4M), 3);
                    OutputCatalogMotorWindingResistanceMinCorrected = RoundDownWithDigits((double)OutputCatalogMotorWindingResistanceAt20CMin * (236.4 + (double)InputMotorTemp) / 256.4, 3);
                    //OutputCatalogMotorWindingResistanceMaxCorrected = Math.Round((decimal)(OutputCatalogMotorWindingResistanceAt20CMax * (236.4M + InputMotorTemp) / 256.4M), 3);
                    OutputCatalogMotorWindingResistanceMaxCorrected = RoundUpWithDigits((double)OutputCatalogMotorWindingResistanceAt20CMax * (236.4 + (double)InputMotorTemp) / 256.4, 3);
                }

            }


            if (null != InputMotorWindingResistanceAB && null != InputMotorWindingResistanceBC && null != InputMotorWindingResistanceCA && null != OutputCatalogMotorWindingResistanceMinCorrected && null != OutputCatalogMotorWindingResistanceMaxCorrected)
            {
                OutputIsMeasuredMotorWindingResistanceABPassed = (InputMotorWindingResistanceAB > OutputCatalogMotorWindingResistanceMinCorrected && InputMotorWindingResistanceAB < OutputCatalogMotorWindingResistanceMaxCorrected) ? "PASSED" : "FAILED";
                OutputIsMeasuredMotorWindingResistanceBCPassed = (InputMotorWindingResistanceBC > OutputCatalogMotorWindingResistanceMinCorrected && InputMotorWindingResistanceBC < OutputCatalogMotorWindingResistanceMaxCorrected) ? "PASSED" : "FAILED";
                OutputIsMeasuredMotorWindingResistanceCAPassed = (InputMotorWindingResistanceCA > OutputCatalogMotorWindingResistanceMinCorrected && InputMotorWindingResistanceCA < OutputCatalogMotorWindingResistanceMaxCorrected) ? "PASSED" : "FAILED";
                OutputAverageMeasuredMotorWindingResistance = (InputMotorWindingResistanceAB + InputMotorWindingResistanceBC + InputMotorWindingResistanceCA) / 3M;
                OutputMeasuredMotorWindingResistancePhaseToPhaseHigh = Math.Max(Math.Max((decimal)InputMotorWindingResistanceAB, (decimal)InputMotorWindingResistanceBC), (decimal)InputMotorWindingResistanceCA);
                OutputMeasuredMotorWindingResistancePhaseToPhaseLow = Math.Min(Math.Min((decimal)InputMotorWindingResistanceAB, (decimal)InputMotorWindingResistanceBC), (decimal)InputMotorWindingResistanceCA);
                OutputDeviationOfMotorWindingResistanceFromHighToAverage = OutputMeasuredMotorWindingResistancePhaseToPhaseHigh - OutputAverageMeasuredMotorWindingResistance;
                OutputDeviationOfMotorWindingResistanceFromAverageToLow = OutputAverageMeasuredMotorWindingResistance - OutputMeasuredMotorWindingResistancePhaseToPhaseLow;
                OutputMaxDeviationOfMotorWindingResistanceFromAverage = Math.Max((decimal)OutputDeviationOfMotorWindingResistanceFromHighToAverage, (decimal)OutputDeviationOfMotorWindingResistanceFromAverageToLow);
                //OutputPercentMaxAllowableDeviationFromAverage = Math.Round((decimal)OutputMaxDeviationOfMotorWindingResistanceFromAverage * 100M / (decimal)OutputAverageMeasuredMotorWindingResistance, 1);
                OutputPercentMaxAllowableDeviationFromAverage = RoundDownWithDigits((double)OutputMaxDeviationOfMotorWindingResistanceFromAverage * 100 / (double)OutputAverageMeasuredMotorWindingResistance, 1);
                OutputIsPercentMADSmallerThan3 = (OutputPercentMaxAllowableDeviationFromAverage <= 3M) ? "PASSED" : "FAILED";
            }
            //OutputInsulationResistanceCheckMinVoltRequired = (motor.Volts < 1000M) ? 500M : ((motor.Volts < 2500M) ? 1000M : ((motor.Volts < 5000M) ? 2500M : 0M));
            if (null != InputMotorTemp)
                OutputInsulationResistanceCorrectionFactor = (decimal)Math.Round(Math.Pow(0.5, ((40 - (double)InputMotorTemp) / 10)), 3);
            if (null != InputMotorTemp && null != InputMeasuredInsulationResistance)
            {
                OutputInsulationResistanceCorrectedTo40C = Math.Round((decimal)OutputInsulationResistanceCorrectionFactor * (decimal)InputMeasuredInsulationResistance, 0);
                OutputIsInsulationResistanceCorrectedTo40CGreaterThan1000 = (OutputInsulationResistanceCorrectedTo40C > 1000M) ? "PASSED" : "FAILED";
            }

            if (null != InputShaftSidePlay)
            {
                OutputIsShaftSidePlayNoGreaterThanPoint25 = (InputShaftSidePlay <= 0.25M) ? "PASSED" : "FAILED";
                if (null != Motor_shaft_extension)
                {
                    OutputCatalogShaftExtensionHeadMax = Motor_shaft_extension.HeadMax;
                    OutputCatalogShaftExtensionHeadMin = Motor_shaft_extension.HeadMin;
                    OutputIsShaftExtensionHeadTestPassed = (InputShaftExtensionHead > OutputCatalogShaftExtensionHeadMin && InputShaftExtensionHead < OutputCatalogShaftExtensionHeadMax) ? "PASSED" : "FAILED";

                }
            }
            if (null != InputOilQualityCheck)
                OutputIsOilQualityBetterThan28kV = (InputOilQualityCheck >= 8) ? "PASSED" : "FAILED";//warning, change criteria to to 20C
            //OutputRecommendedLowVoltStartAt60Hz = 0.4M * motor.Volts;
            if (null != InputRPMAfterLowVoltStart)
                OutputIsRPMAfterLowVoltNoLessThan3400 = (InputRPMAfterLowVoltStart >= 3400M) ? "PASSED" : "FAILED";
            if (null != InputVoltVa && null != InputVoltVb && null != InputVoltVc)
            {
                OutputVoltAverage = Math.Round((decimal)(InputVoltVa + InputVoltVb + InputVoltVc) / 3M, 0);
                OuputVoltHigh = DecimalMax(InputVoltVa, InputVoltVb, InputVoltVc);
                OutputVoltLow = DecimalMin(InputVoltVa, InputVoltVb, InputVoltVc);
                OutputVoltDeviationHigh = OuputVoltHigh - OutputVoltAverage;
                OutputVoltDeviationLow = OutputVoltAverage - OutputVoltLow;
                OutputVoltDeviationMax = Math.Max((decimal)OutputVoltDeviationHigh, (decimal)OutputVoltDeviationLow);
                OutputMaxAllowableVoltDeviation = Math.Round((decimal)OutputVoltDeviationMax * 100M / (decimal)OutputVoltAverage, 1);
                OutputIsMAVDSmallerThanPercent1point5 = (OutputMaxAllowableVoltDeviation <= 1.5M) ? "PASSED" : "FAILED";
            }
            if (null != InputCurrentIAWithMaxVoltUnbalancePercent1point5 && null != InputCurrentIBWithMaxVoltUnbalancePercent1point5 && null != InputCurrentICWithMaxVoltUnbalancePercent1point5)
            {
                OutputCurrentIHigh = DecimalMax(InputCurrentIAWithMaxVoltUnbalancePercent1point5, InputCurrentIBWithMaxVoltUnbalancePercent1point5, InputCurrentICWithMaxVoltUnbalancePercent1point5);
                OutputCurrentILow = DecimalMin(InputCurrentIAWithMaxVoltUnbalancePercent1point5, InputCurrentIBWithMaxVoltUnbalancePercent1point5, InputCurrentICWithMaxVoltUnbalancePercent1point5);
                OutputCurrentIAverage = DecimalAvgsWithDigits(InputCurrentIAWithMaxVoltUnbalancePercent1point5, InputCurrentIBWithMaxVoltUnbalancePercent1point5, InputCurrentICWithMaxVoltUnbalancePercent1point5, 1);
                OutputCurrentDeviationHigh = OutputCurrentIHigh - OutputCurrentIAverage;
                OutputCurrentDeviationLow = OutputCurrentIAverage - OutputCurrentILow;
                OutputMaxCurrentDeviation = Math.Max((decimal)OutputCurrentDeviationHigh, (decimal)OutputCurrentDeviationLow);
                OutputMaxAllowableCurrentDeviation = Math.Round((decimal)OutputMaxCurrentDeviation * 100M / (decimal)OutputCurrentIAverage, 1);
                OutputIsMACDSmallerThanPercent3 = CheckPassWithCondition(OutputMaxAllowableCurrentDeviation < 3M);

            }


            if (null != InputMotorTempRiseAfter11MinutesOfFullVoltTest)
                OutputIsMotorTempRiseAfter11MinutesOfFullVoltTestLessThan40C = CheckPassWithCondition(InputMotorTempRiseAfter11MinutesOfFullVoltTest <= 40);
            if (null != InputRPMAt60HzWhenMotorTempReached60C)
                OutputIsRPMAt60HzWhenMotorTempReached60CHigherThan3500 = CheckPassWithCondition(InputRPMAt60HzWhenMotorTempReached60C >= 3500);
            if (null != OutputCatalogMotorWindingResistanceAt20CMin && null != OutputCatalogMotorWindingResistanceAt20CMax && null != InputMotorTempAfterIdle)
            {
                //OutputCatalogMotorWindingResistanceMinCorrectedAfterIdle = Math.Round((decimal)(OutputCatalogMotorWindingResistanceAt20CMin * (236.4M + InputMotorTempAfterIdle) / 256.4M), 3);
                OutputCatalogMotorWindingResistanceMinCorrectedAfterIdle = RoundDownWithDigits((double)OutputCatalogMotorWindingResistanceAt20CMin * (236.4 + (double)InputMotorTempAfterIdle) / 256.4, 3);
                //OutputCatalogMotorWindingResistanceMaxCorrectedAfterIdle = Math.Round((decimal)(OutputCatalogMotorWindingResistanceAt20CMax * (236.4M + InputMotorTempAfterIdle) / 256.4M), 3);
                OutputCatalogMotorWindingResistanceMaxCorrectedAfterIdle = RoundUpWithDigits((double)OutputCatalogMotorWindingResistanceAt20CMax * (236.4 + (double)InputMotorTempAfterIdle) / 256.4, 3);
                if (null != InputMotorWindingResistanceABAfterIdle && null != InputMotorWindingResistanceBCAfterIdle && null != InputMotorWindingResistanceCAAfterIdle)
                {
                    OutputIsMeasuredMotorWindingResistanceABPassedAfterIdle = CheckPassWithCondition(InputMotorWindingResistanceABAfterIdle > OutputCatalogMotorWindingResistanceMinCorrectedAfterIdle && InputMotorWindingResistanceABAfterIdle < OutputCatalogMotorWindingResistanceMaxCorrectedAfterIdle);
                    OutputIsMeasuredMotorWindingResistanceBCPassedAfterIdle = CheckPassWithCondition(InputMotorWindingResistanceBCAfterIdle > OutputCatalogMotorWindingResistanceMinCorrectedAfterIdle && InputMotorWindingResistanceBCAfterIdle < OutputCatalogMotorWindingResistanceMaxCorrectedAfterIdle);
                    OutputIsMeasuredMotorWindingResistanceCAPassedAfterIdle = CheckPassWithCondition(InputMotorWindingResistanceCAAfterIdle > OutputCatalogMotorWindingResistanceMinCorrectedAfterIdle && InputMotorWindingResistanceCAAfterIdle < OutputCatalogMotorWindingResistanceMaxCorrectedAfterIdle);
                    OutputAverageMeasuredMotorWindingResistanceAfterIdle = DecimalAvgsWithDigits(InputMotorWindingResistanceABAfterIdle, InputMotorWindingResistanceBCAfterIdle, InputMotorWindingResistanceCAAfterIdle, 3);
                    OutputMeasuredMotorWindingResistancePhaseToPhaseHighAfterIdle = DecimalMax(InputMotorWindingResistanceABAfterIdle, InputMotorWindingResistanceBCAfterIdle, InputMotorWindingResistanceCAAfterIdle);
                    OutputMeasuredMotorWindingResistancePhaseToPhaseLowAfterIdle = DecimalMin(InputMotorWindingResistanceABAfterIdle, InputMotorWindingResistanceBCAfterIdle, InputMotorWindingResistanceCAAfterIdle);
                    OutputDeviationOfMotorWindingResistanceFromHighToAvgsAfterIdle = OutputMeasuredMotorWindingResistancePhaseToPhaseHighAfterIdle - OutputAverageMeasuredMotorWindingResistanceAfterIdle;
                    OutputDeviationOfMotorWindingResistanceFromAvgsToLowAfterIdle = OutputAverageMeasuredMotorWindingResistanceAfterIdle - OutputMeasuredMotorWindingResistancePhaseToPhaseLowAfterIdle;
                    OutputMaxDeviationOfMotorWindingResistanceFromAverage = Math.Max((decimal)OutputDeviationOfMotorWindingResistanceFromHighToAvgsAfterIdle, (decimal)OutputDeviationOfMotorWindingResistanceFromAvgsToLowAfterIdle);
                    //OutputPercentMaxAllowableDeviationFromAverageAfterIdle = Math.Round((decimal)OutputMaxDeviationOfMotorWindingResistanceFromAverage * 100M / (decimal)OutputAverageMeasuredMotorWindingResistanceAfterIdle, 1);
                    OutputPercentMaxAllowableDeviationFromAverageAfterIdle = RoundDownWithDigits((double)OutputMaxDeviationOfMotorWindingResistanceFromAverage * 100 / (double)OutputAverageMeasuredMotorWindingResistanceAfterIdle, 1);
                    OutputIsPercentMADSmallerThan3AfterIdle = CheckPassWithCondition(OutputPercentMaxAllowableDeviationFromAverageAfterIdle <= 3);
                }
            }

            if (null != InputMotorTempAfterIdle && null != InputMeasuredInsulationResistanceAfterIdle)
            {
                OutputInsulationResistanceCorrectionFactorAfterIdle = (decimal)Math.Round(Math.Pow(0.5, ((40 - (double)InputMotorTempAfterIdle) / 10)), 3);
                //OutputInsulationResistanceCorrectedTo40CAfterIdle = OutputInsulationResistanceCorrectionFactorAfterIdle * InputMeasuredInsulationResistanceAfterIdle;
                OutputInsulationResistanceCorrectedTo40CAfterIdle = Math.Round((decimal)OutputInsulationResistanceCorrectionFactorAfterIdle * (decimal)InputMeasuredInsulationResistanceAfterIdle, 0);
                OutputIsInsulationResistanceCorrectedTo40CExceed1000AfterIdle = CheckPassWithCondition(OutputInsulationResistanceCorrectedTo40CAfterIdle > 1000);
            }

            if (null != InputTempAtWhichPIWasPerformed && null != InputPITestForMotorAtTempBellow38C)
                OutputIsPIHigherThanOne = CheckPassWithCondition(InputTempAtWhichPIWasPerformed <= 38 && InputPITestForMotorAtTempBellow38C > 1);


        }

        public decimal DecimalMax(decimal? a, decimal? b, decimal? c)
        {
            decimal? max = (a > b) ? a : b;
            max = (max > c) ? max : c;
            return (decimal)max;
        }

        public decimal DecimalMin(decimal? a, decimal? b, decimal? c)
        {
            decimal? min = (a < b) ? a : b;
            min = (min < c) ? min : c;
            return (decimal)min;
        }

        public decimal DecimalAvgsWithDigits(decimal? a, decimal? b, decimal? c, int d)
        {
            decimal? avgs = (a + b + c) / 3M;
            return Math.Round((decimal)avgs, d);

        }

        public string CheckPassWithCondition(bool b)
        {
            return b ? "PASSED" : "FAILED";
        }

        public decimal RoundDownWithDigits(double a, int b)
        {
            return (decimal)(Math.Floor(a * Math.Pow(10, b)) / Math.Pow(10, b));
        }

        public decimal RoundUpWithDigits(double a, int b)
        {
            return (decimal)(Math.Ceiling(a * Math.Pow(10, b)) / Math.Pow(10, b));
        }
    }
}
