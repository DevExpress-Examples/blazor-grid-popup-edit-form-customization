<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/1032499589/25.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1317391)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Blazor Grid - Use an External Popup as an Edit Form

This example uses a [DevExpress Blazor Popup](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup) as a custom edit form for the [DevExpress Blazor Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) component. In this example, the edit form is resizable/draggable, and does not close on Escape.

![Customizable Popup Edit Form](./result.png)

## Implementation Details

Add a [command column](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) to your Grid markup. Use [HeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.HeaderTemplate) and [CellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.CellDisplayTemplate) to add custom **New** and **Edit** buttons.

```
<DxGrid>
    <Columns>
        <DxGridCommandColumn>
            <HeaderTemplate>
                <DxButton Text="New" Click="() => ShowPopup(new WeatherForecast())"></DxButton>
            </HeaderTemplate>
            <CellDisplayTemplate>
                <DxButton Text="Edit" Click="() => ShowPopup(context.DataItem)"></DxButton>
            </CellDisplayTemplate>
        </DxGridCommandColumn>
        // ...
    </Columns>
</DxGrid>
```

Add a `DxPopup` component and populate it with required edit form content. This example uses [DxFormLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout) to arrange editors and an [EditForm](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.editform) to validate user input.

```
@if(PopupVisible) {
    <DxPopup Visible="PopupVisible">
        <BodyContentTemplate>
            <EditForm Model="@editModel" OnValidSubmit="OnValidSubmit">
                <DataAnnotationsValidator></DataAnnotationsValidator>
                <DxFormLayout Data="@editModel">
                  // ...
                     <DxFormLayoutItem>
                        <DxButton Text="Save" SubmitFormOnClick=true></DxButton>
                        <DxButton Text="Cancel" Click="ClosePopup"></DxButton>
                     </DxFormLayoutItem>
                </DxFormLayout>
            </EditForm>
        </BodyContentTemplate>
    </DxPopup>
}
```

Implement `ShowPopup()`/`ClosePopup()` methods that create/reset an [edit model](https://docs.devexpress.com/Blazor/404759/components/grid/editing-and-validation/edit-model) (record data). When an edit model is available, the popup form is visible. 

```
@code {
   private WeatherForecast? editModel;
   private bool PopupVisible => editModel != null;

   private void ShowPopup(object dataItem) {
      // ...
      editModel = new WeatherForecast() {
         // ...
      };
   }
    private void ClosePopup() {
        editModel = null;
    }
}
```

When a user submits the form and validation is successful ([EditForm.OnValidSubmit()](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.editform.onvalidsubmit#microsoft-aspnetcore-components-forms-editform-onvalidsubmit)), update the data source. Create a new record, if necessary, and post new values.

```
private bool IsNew => !forecasts.Any(f => f.ID == editModel!.ID);
private void OnValidSubmit(EditContext ctx) {
    // ...
    if(IsNew)
        InsertRecord(wf);
    else
        UpdateRecord(wf);
    // ...
}
```

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




