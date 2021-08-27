<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581900/12.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4572)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/StandaloneCustForm/Form1.cs) (VB: [Form1.vb](./VB/StandaloneCustForm/Form1.vb))
<!-- default file list end -->
# How to display the Customization Form near the PivotGridControl


<p>This example demonstrates how to display the Customization Form near the PivotGridControl.</p><p>In this example, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsSplitContainerControlMembersTopicAll"><u>SplitContainerControl</u></a> is used as a parent container for the PivotGridControl and Customization Form. The <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_ShowingCustomizationFormtopic"><u>ShowingCustomizationForm</u></a> event is handled to change the default behaviour of the Customization Form. The <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridCustomizationFormShowingEventArgs_ParentControltopic"><u>ParentControl</u></a> property is used to set <a href="ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/fxref_system.windows.forms/html/c811df29-0a1f-2637-ca2f-c3a69af08a03.htm"><u>SplitContainer.Panel2</u></a> as an owner of the Customization Form. The Customization Form is docked to the parent container using the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsCreateCustomizationFormEventArgs_CustomizationFormtopic"><u>CustomizationForm</u></a> property.<br />
The style of the Customization Form is set using the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridOptionsCustomization_CustomizationFormStyletopic"><u>CustomizationFormStyle</u></a> property. The <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_FieldsCustomizationtopic"><u>FieldsCustomization</u></a> method is used to invoke the Customization Form. </p>

<br/>


