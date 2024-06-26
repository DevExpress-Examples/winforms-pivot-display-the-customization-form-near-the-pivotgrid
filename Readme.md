<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581900/18.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4572)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/StandaloneCustForm/Form1.cs) (VB: [Form1.vb](./VB/StandaloneCustForm/Form1.vb))
<!-- default file list end -->
# How to display the Customization Form near the PivotGridControl


This example demonstrates how to display the Customization Form near the PivotGridControl.

When displayed, the form is located in the [SplitContainerControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.SplitContainerControl) - a parent container for the PivotGridControl and Customization Form. To specify the SplitContainer's panel as the Customization Form's owner, handle the  [PivotGridControl.ShowingCustomizationForm](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.ShowingCustomizationForm) event and use the [CustomizationFormShowingEventArgs.ParentControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.CustomizationFormShowingEventArgs.ParentControl) property. 

The form's appearance is specified with the [PivotGridOptionsCustomization.CustomizationFormStyle](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridOptionsCustomization.CustomizationFormStyle) property.

Call the [PivotGridControl.FieldsCustomization](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.FieldsCustomization.overloads) method to show the form.

![screenshot](./images/screenshot.png)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-display-the-customization-form-near-the-pivotgrid&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-display-the-customization-form-near-the-pivotgrid&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
