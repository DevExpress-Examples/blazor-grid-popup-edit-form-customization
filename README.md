<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/1032499589/25.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1317391)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Blazor Grid - Use an External Popup to Customize an Edit Form

This example uses a [DevExpress Blazor Popup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup) dialog alongside our [Blazor Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) to customize a pop-up edit form. In this example, the edit form is resizable and draggable, and does not close on Escape.

![Customizable Popup Edit Form](result.png)

## Implementation Details

1. Create a custom dialog using `DxPopup` as your requirements dictate. Add edit form (dialog) content. In this example, we use a [DxFormLayout]() to arrange editors and an [EditForm](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.editform) to validate user input.
1. Add a [command column](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) to your Grid markup and disable built-in command buttons.
1. Use [HeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.HeaderTemplate) and [CellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.CellDisplayTemplate) to add buttons for custom **New** and **Edit** dialogs.
1. Implement a method that creates an [edit model](https://docs.devexpress.com/Blazor/404759/components/grid/editing-and-validation/edit-model) for a new or existing record (`ShowPopup` in our implementation).
1. When user input is valid ([EditForm.OnValidSubmit](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.editform.onvalidsubmit#microsoft-aspnetcore-components-forms-editform-onvalidsubmit)), create a new record or update existing one.

## Files to Review

- [Index.razor](./CS/DxBlazorApplication1/Components/Pages/Index.razor)

## Documentation

- [Pop-Up and Inline Edit Forms in Blazor Grid](https://docs.devexpress.com/Blazor/404757/components/grid/editing-and-validation/edit-modes/edit-forms)
- [DxPopup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup)

## More Examples

- [Grid for Blazor - How to edit a row on a separate page](https://github.com/DevExpress-Examples/blazor-grid-separate-edit-form)
- [Grid for Blazor - Create a custom record deletion confirmation dialog](https://github.com/DevExpress-Examples/blazor-grid-show-custom-confirmation-dialog)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=grid-external-popup-example&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=grid-external-popup-example&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
