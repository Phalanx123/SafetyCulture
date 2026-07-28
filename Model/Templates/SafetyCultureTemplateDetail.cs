using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Templates
{
    public class GetTemplateByInspectionResponse
    {
        [JsonPropertyName("template")]
        public SafetyCultureTemplateDetail Template { get; set; }
    }

    public class SafetyCultureTemplateDetail
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("revision_id")]
        public string RevisionId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("permissions")]
        public TemplatePermissions Permissions { get; set; }

        [JsonPropertyName("items")]
        public List<TemplateItem> Items { get; set; }

        [JsonPropertyName("response_sets")]
        public List<TemplateResponseSet> ResponseSets { get; set; }

        [JsonPropertyName("global_response_sets")]
        public List<TemplateResponseSet> GlobalResponseSets { get; set; }

        [JsonPropertyName("title_rules")]
        public List<string> TitleRules { get; set; }

        [JsonPropertyName("media")]
        public List<TemplateMedium> Media { get; set; }

        [JsonPropertyName("mandatory_mark_as_complete")]
        public bool? MandatoryMarkAsComplete { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTimeOffset? ModifiedAt { get; set; }

        [JsonPropertyName("author")]
        public TemplatePerson Author { get; set; }

        [JsonPropertyName("owner")]
        public TemplatePerson Owner { get; set; }

        [JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        [JsonPropertyName("metadata_image")]
        public TemplateMedium MetadataImage { get; set; }

        [JsonPropertyName("access_level")]
        public string AccessLevel { get; set; }

        [JsonPropertyName("last_used")]
        public DateTimeOffset? LastUsed { get; set; }

        [JsonPropertyName("added_at")]
        public DateTimeOffset? AddedAt { get; set; }

        [JsonPropertyName("revision_key")]
        public string RevisionKey { get; set; }

        [JsonPropertyName("support_site_as_question_type")]
        public bool? SupportSiteAsQuestionType { get; set; }

        [JsonPropertyName("date_draft_modified")]
        public DateTimeOffset? DateDraftModified { get; set; }

        [JsonPropertyName("draft_author_name")]
        public string DraftAuthorName { get; set; }

        [JsonPropertyName("origin_information")]
        public object OriginInformation { get; set; }

        [JsonPropertyName("translation_id")]
        public string TranslationId { get; set; }

        [JsonPropertyName("is_locked_from_shared_library")]
        public bool? IsLockedFromSharedLibrary { get; set; }

        [JsonPropertyName("settings")]
        public TemplateSettings Settings { get; set; }

        [JsonPropertyName("document_links")]
        public List<object> DocumentLinks { get; set; }

        [JsonPropertyName("procurement_order_settings")]
        public object ProcurementOrderSettings { get; set; }
    }

    public class TemplatePermissions
    {
        [JsonPropertyName("edit")]
        public List<TemplatePermissionEntry> Edit { get; set; }

        [JsonPropertyName("view")]
        public List<TemplatePermissionEntry> View { get; set; }

        [JsonPropertyName("owner")]
        public List<TemplatePermissionEntry> Owner { get; set; }

        [JsonPropertyName("delete")]
        public List<TemplatePermissionEntry> Delete { get; set; }

        [JsonPropertyName("context")]
        public List<TemplatePermissionEntry> Context { get; set; }
    }

    public class TemplatePermissionEntry
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class TemplateItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("children")]
        public List<TemplateItem> Children { get; set; }

        [JsonPropertyName("section")]
        public TemplateSectionItem Section { get; set; }

        [JsonPropertyName("category")]
        public TemplateCategoryItem Category { get; set; }

        [JsonPropertyName("site")]
        public TemplateOptionsItem Site { get; set; }

        [JsonPropertyName("datetime")]
        public TemplateDatetimeItem Datetime { get; set; }

        [JsonPropertyName("textsingle")]
        public TemplateTextSingleItem TextSingle { get; set; }

        [JsonPropertyName("text")]
        public TemplateOptionsItem Text { get; set; }

        [JsonPropertyName("address")]
        public TemplateOptionsItem Address { get; set; }

        [JsonPropertyName("instruction")]
        public TemplateInstructionItem Instruction { get; set; }

        [JsonPropertyName("dynamicfield")]
        public TemplateOptionsItem DynamicField { get; set; }

        [JsonPropertyName("question")]
        public TemplateQuestionItem Question { get; set; }

        [JsonPropertyName("list")]
        public TemplateListItem List { get; set; }

        [JsonPropertyName("logicfield")]
        public TemplateLogicFieldItem LogicField { get; set; }

        [JsonPropertyName("media")]
        public TemplateOptionsItem Media { get; set; }

        [JsonPropertyName("signature")]
        public TemplateOptionsItem Signature { get; set; }
    }

    public class TemplateItemOptions
    {
        [JsonPropertyName("is_mandatory")]
        public bool? IsMandatory { get; set; }

        [JsonPropertyName("weighting")]
        public double? Weighting { get; set; }
    }

    public class TemplateOptionsItem
    {
        [JsonPropertyName("options")]
        public TemplateItemOptions Options { get; set; }
    }

    public class TemplateSectionItem
    {
        [JsonPropertyName("section_type")]
        public string SectionType { get; set; }

        [JsonPropertyName("autoshares")]
        public object Autoshares { get; set; }

        [JsonPropertyName("approvers")]
        public object Approvers { get; set; }

        [JsonPropertyName("user_defined_approvers")]
        public bool? UserDefinedApprovers { get; set; }
    }

    public class TemplateCategoryItem
    {
    }

    public class TemplateDatetimeItem
    {
        [JsonPropertyName("options")]
        public TemplateItemOptions Options { get; set; }

        [JsonPropertyName("enable_date")]
        public bool? EnableDate { get; set; }

        [JsonPropertyName("enable_time")]
        public bool? EnableTime { get; set; }
    }

    public class TemplateTextSingleItem
    {
        [JsonPropertyName("options")]
        public TemplateItemOptions Options { get; set; }

        [JsonPropertyName("text_format")]
        public string TextFormat { get; set; }

        [JsonPropertyName("calculation_data")]
        public object CalculationData { get; set; }

        [JsonPropertyName("unit_symbol")]
        public string UnitSymbol { get; set; }

        [JsonPropertyName("reading_config_id")]
        public string ReadingConfigId { get; set; }
    }

    public class TemplateInstructionItem
    {
        [JsonPropertyName("text")]
        public object Text { get; set; }
    }

    public class TemplateQuestionItem
    {
        [JsonPropertyName("options")]
        public TemplateItemOptions Options { get; set; }

        [JsonPropertyName("failed_responses")]
        public List<string> FailedResponses { get; set; }

        [JsonPropertyName("response_set_id")]
        public string ResponseSetId { get; set; }

        [JsonPropertyName("calculation_data")]
        public object CalculationData { get; set; }
    }

    public class TemplateListItem
    {
        [JsonPropertyName("options")]
        public TemplateItemOptions Options { get; set; }

        [JsonPropertyName("failed_responses")]
        public List<string> FailedResponses { get; set; }

        [JsonPropertyName("response_set_id")]
        public string ResponseSetId { get; set; }

        [JsonPropertyName("multiple_selection")]
        public bool? MultipleSelection { get; set; }

        [JsonPropertyName("calculation_data")]
        public object CalculationData { get; set; }
    }

    public class TemplateLogicFieldItem
    {
        [JsonPropertyName("response_is")]
        public TemplateLogicFieldResponseIs ResponseIs { get; set; }

        [JsonPropertyName("require_note")]
        public bool? RequireNote { get; set; }

        [JsonPropertyName("require_media")]
        public bool? RequireMedia { get; set; }

        [JsonPropertyName("require_action")]
        public bool? RequireAction { get; set; }

        [JsonPropertyName("skip_to")]
        public object SkipTo { get; set; }

        [JsonPropertyName("preset_action_type_ids")]
        public List<string> PresetActionTypeIds { get; set; }

        [JsonPropertyName("procurement_trigger")]
        public bool? ProcurementTrigger { get; set; }
    }

    public class TemplateLogicFieldResponseIs
    {
        [JsonPropertyName("responses")]
        public List<string> Responses { get; set; }
    }

    public class TemplateResponseSet
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("responses")]
        public List<TemplateResponseSetResponse> Responses { get; set; }

        [JsonPropertyName("is_grs")]
        public bool? IsGrs { get; set; }
    }

    public class TemplateResponseSetResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("score")]
        public double? Score { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("score_enabled")]
        public bool? ScoreEnabled { get; set; }
    }

    public class TemplateMedium
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("filename")]
        public string Filename { get; set; }

        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }
    }

    public class TemplatePerson
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class TemplateSettings
    {
        [JsonPropertyName("is_add_note_disabled")]
        public bool? IsAddNoteDisabled { get; set; }

        [JsonPropertyName("is_attach_media_disabled")]
        public bool? IsAttachMediaDisabled { get; set; }

        [JsonPropertyName("is_create_action_disabled")]
        public bool? IsCreateActionDisabled { get; set; }

        [JsonPropertyName("is_inspection_completion_dialog_confirmation_disabled")]
        public bool? IsInspectionCompletionDialogConfirmationDisabled { get; set; }
    }
}
