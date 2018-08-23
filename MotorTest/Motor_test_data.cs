//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MotorTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Motor_test_data
    {
        public int ID { get; set; }
        public int ID_Motor { get; set; }
        public int ID_Motor_Shaft_Extension { get; set; }
        public string InputReportID { get; set; }
        public string InputCustomerName { get; set; }
        public string InputRuntimeForIdleTest { get; set; }
        public string InputComments { get; set; }
        public string InputFieldName { get; set; }
        public string InputMotorSN { get; set; }
        public string InputTestedBy { get; set; }
        public string InputTestDate { get; set; }
        public string InputChooseSupplier { get; set; }
        public string InputChooseSeries { get; set; }
        public string InputChooseModel { get; set; }
        public Nullable<decimal> InputShaftExtensionBase { get; set; }
        public string InputChooseMotorConfigForShaftExtension { get; set; }
        public Nullable<decimal> OutputRecommendedLowVoltStartAt60Hz { get; set; }
        public string InputChooseDidMotorStartedWithLowVoltAt60Hz { get; set; }
        public Nullable<decimal> InputRPMAfterLowVoltStart { get; set; }
        public string OutputIsRPMAfterLowVoltNoLessThan3400 { get; set; }
        public Nullable<decimal> InputVoltVa { get; set; }
        public Nullable<decimal> InputVoltVb { get; set; }
        public Nullable<decimal> InputVoltVc { get; set; }
        public Nullable<decimal> OutputVoltAverage { get; set; }
        public Nullable<decimal> OuputVoltHigh { get; set; }
        public Nullable<decimal> OutputVoltLow { get; set; }
        public Nullable<decimal> OutputVoltDeviationHigh { get; set; }
        public Nullable<decimal> OutputVoltDeviationLow { get; set; }
        public Nullable<decimal> OutputVoltDeviationMax { get; set; }
        public Nullable<decimal> OutputMaxAllowableVoltDeviation { get; set; }
        public string OutputIsMAVDSmallerThanPercent1point5 { get; set; }
        public Nullable<decimal> InputCurrentIAWithMaxVoltUnbalancePercent1point5 { get; set; }
        public Nullable<decimal> InputCurrentIBWithMaxVoltUnbalancePercent1point5 { get; set; }
        public Nullable<decimal> InputCurrentICWithMaxVoltUnbalancePercent1point5 { get; set; }
        public Nullable<decimal> OutputCurrentIHigh { get; set; }
        public Nullable<decimal> OutputCurrentILow { get; set; }
        public Nullable<decimal> OutputCurrentIAverage { get; set; }
        public Nullable<decimal> OutputCurrentDeviationHigh { get; set; }
        public Nullable<decimal> OutputCurrentDeviationLow { get; set; }
        public Nullable<decimal> OutputMaxCurrentDeviation { get; set; }
        public Nullable<decimal> OutputMaxAllowableCurrentDeviation { get; set; }
        public string OutputIsMACDSmallerThanPercent3 { get; set; }
        public Nullable<decimal> InputMotorTempRiseAfter11MinutesOfFullVoltTest { get; set; }
        public Nullable<decimal> InputMotorTemp { get; set; }
        public Nullable<decimal> InputMotorWindingResistanceAB { get; set; }
        public Nullable<decimal> InputMotorWindingResistanceBC { get; set; }
        public Nullable<decimal> InputMotorWindingResistanceCA { get; set; }
        public Nullable<decimal> OutputCatalogMotorWindingResistanceAt20CMin { get; set; }
        public Nullable<decimal> OutputCatalogMotorWindingResistanceMinCorrected { get; set; }
        public Nullable<decimal> OutputCatalogMotorWindingResistanceAt20CMax { get; set; }
        public Nullable<decimal> OutputCatalogMotorWindingResistanceMaxCorrected { get; set; }
        public string OutputIsMeasuredMotorWindingResistanceABPassed { get; set; }
        public string OutputIsMeasuredMotorWindingResistanceBCPassed { get; set; }
        public string OutputIsMeasuredMotorWindingResistanceCAPassed { get; set; }
        public Nullable<decimal> OutputAverageMeasuredMotorWindingResistance { get; set; }
        public Nullable<decimal> OutputMeasuredMotorWindingResistancePhaseToPhaseHigh { get; set; }
        public Nullable<decimal> OutputMeasuredMotorWindingResistancePhaseToPhaseLow { get; set; }
        public Nullable<decimal> OutputDeviationOfMotorWindingResistanceFromHighToAverage { get; set; }
        public Nullable<decimal> OutputDeviationOfMotorWindingResistanceFromAverageToLow { get; set; }
        public Nullable<decimal> OutputMaxDeviationOfMotorWindingResistanceFromAverage { get; set; }
        public Nullable<decimal> OutputPercentMaxAllowableDeviationFromAverage { get; set; }
        public string OutputIsPercentMADSmallerThan3 { get; set; }
        public Nullable<decimal> OutputInsulationResistanceCheckMinVoltRequired { get; set; }
        public Nullable<decimal> OutputInsulationResistanceCorrectionFactor { get; set; }
        public Nullable<decimal> InputMeasuredInsulationResistance { get; set; }
        public Nullable<decimal> OutputInsulationResistanceCorrectedTo40C { get; set; }
        public string OutputIsInsulationResistanceCorrectedTo40CGreaterThan1000 { get; set; }
        public Nullable<decimal> InputShaftSidePlay { get; set; }
        public string OutputIsShaftSidePlayNoGreaterThanPoint25 { get; set; }
        public Nullable<decimal> InputShaftExtensionHead { get; set; }
        public Nullable<decimal> OutputCatalogShaftExtensionHeadMax { get; set; }
        public Nullable<decimal> OutputCatalogShaftExtensionHeadMin { get; set; }
        public string OutputIsShaftExtensionHeadTestPassed { get; set; }
        public Nullable<decimal> InputOilQualityCheck { get; set; }
        public string OutputIsOilQualityBetterThan28kV { get; set; }
        public string InputChooseIsAirTestPassed { get; set; }
        public string OutputIsMotorTempRiseAfter11MinutesOfFullVoltTestLessThan40C { get; set; }
        public Nullable<decimal> InputRPMAt60HzWhenMotorTempReached60C { get; set; }
        public string OutputIsRPMAt60HzWhenMotorTempReached60CHigherThan3500 { get; set; }
        public Nullable<decimal> InputMotorTempAfterIdle { get; set; }
        public Nullable<decimal> InputMotorWindingResistanceABAfterIdle { get; set; }
        public Nullable<decimal> InputMotorWindingResistanceBCAfterIdle { get; set; }
        public Nullable<decimal> InputMotorWindingResistanceCAAfterIdle { get; set; }
        public Nullable<decimal> OutputCatalogMotorWindingResistanceMinCorrectedAfterIdle { get; set; }
        public Nullable<decimal> OutputCatalogMotorWindingResistanceMaxCorrectedAfterIdle { get; set; }
        public string OutputIsMeasuredMotorWindingResistanceABPassedAfterIdle { get; set; }
        public string OutputIsMeasuredMotorWindingResistanceBCPassedAfterIdle { get; set; }
        public string OutputIsMeasuredMotorWindingResistanceCAPassedAfterIdle { get; set; }
        public Nullable<decimal> OutputAverageMeasuredMotorWindingResistanceAfterIdle { get; set; }
        public Nullable<decimal> OutputMeasuredMotorWindingResistancePhaseToPhaseHighAfterIdle { get; set; }
        public Nullable<decimal> OutputMeasuredMotorWindingResistancePhaseToPhaseLowAfterIdle { get; set; }
        public Nullable<decimal> OutputDeviationOfMotorWindingResistanceFromHighToAvgsAfterIdle { get; set; }
        public Nullable<decimal> OutputDeviationOfMotorWindingResistanceFromAvgsToLowAfterIdle { get; set; }
        public Nullable<decimal> OutputMaxDeviationOfMotorWindingResistanceFromAverageAfterIdle { get; set; }
        public Nullable<decimal> OutputPercentMaxAllowableDeviationFromAverageAfterIdle { get; set; }
        public string OutputIsPercentMADSmallerThan3AfterIdle { get; set; }
        public Nullable<decimal> OutputInsulationResistanceCorrectionFactorAfterIdle { get; set; }
        public Nullable<decimal> InputMeasuredInsulationResistanceAfterIdle { get; set; }
        public Nullable<decimal> OutputInsulationResistanceCorrectedTo40CAfterIdle { get; set; }
        public string OutputIsInsulationResistanceCorrectedTo40CExceed1000AfterIdle { get; set; }
        public Nullable<decimal> InputTempAtWhichPIWasPerformed { get; set; }
        public Nullable<decimal> InputPITestForMotorAtTempBellow38C { get; set; }
        public string OutputIsPIHigherThanOne { get; set; }
    
        public virtual Motor_shaft_extension Motor_shaft_extension { get; set; }
        public virtual Motor Motor { get; set; }
    }
}