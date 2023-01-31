using Umbraco.Cms.Core.PropertyEditors;

namespace Our.Umbraco.CompositionPicker.DataEditors;

[DataEditor(
    DataEditorAlias,
    EditorType.PropertyValue,
    DataEditorName,
    DataEditorViewPath,
    ValueType = ValueTypes.Text,
    Group = Constants.Conventions.PropertyGroups.Pickers,
    Icon = DataEditorIcon)]
internal class CompositionPickerDataEditor : DataEditor
{
    internal const string DataEditorAlias = "CompositionPicker";
    internal const string DataEditorName = "Composition Picker";
    internal const string DataEditorViewPath = Constants.Internals.EditorPathRoot + "composition-picker-editor.html";
    internal const string DataEditorIcon = "icon-defrag";

    public CompositionPickerDataEditor(
        IDataValueEditorFactory dataValueEditorFactory, 
        EditorType type = EditorType.PropertyValue) 
        : base(dataValueEditorFactory, type)
    {
    }
}
