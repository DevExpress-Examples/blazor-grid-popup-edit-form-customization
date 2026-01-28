<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1317391)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Blazor Grid - Use an External Popup as an Edit Form

This example uses a [DevExpress Blazor Popup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup) as a custom edit form for the [DevExpress Blazor Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) component. In this example, the edit form is resizable/draggable, and does not close on Escape.

![Customizable Popup Edit Form](./result.png)

## Implementation Details

1. Add a `DxPopup` component and populate it with required edit form content. This example uses [DxFormLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout) to arrange editors and an [EditForm](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.editform) to validate user input.
1. Add a [command column](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) to your Grid markup. Use [HeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.HeaderTemplate) and [CellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.CellDisplayTemplate) to add custom **New** and **Edit** buttons.
1. Implement a method that creates an [edit model](https://docs.devexpress.com/Blazor/404759/components/grid/editing-and-validation/edit-model) for a new or existing record (`ShowPopup()` in our implementation).
1. When a user submits the form and validation is successful ([EditForm.OnValidSubmit](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.editform.onvalidsubmit#microsoft-aspnetcore-components-forms-editform-onvalidsubmit)), update the data source. Create a new record, if necessary, and post new values.

## Files to Review

- [Index.razor](./CS/BlazorGridPopupEditFormCustomization/Components/Pages/Index.razor)

## Documentation

- [Pop-Up and Inline Edit Forms in Blazor Grid](https://docs.devexpress.com/Blazor/404757/components/grid/editing-and-validation/edit-modes/edit-forms)
- [DxPopup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup)

## More Examples

- [Grid for Blazor - How to edit a row on a separate page](https://github.com/DevExpress-Examples/blazor-grid-separate-edit-form)
- [Grid for Blazor - Create a custom record deletion confirmation dialog](https://github.com/DevExpress-Examples/blazor-grid-show-custom-confirmation-dialog)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-grid-popup-edit-form-customization&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-grid-popup-edit-form-customization&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->





