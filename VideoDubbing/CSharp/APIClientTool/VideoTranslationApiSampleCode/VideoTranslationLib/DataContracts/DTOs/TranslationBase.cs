﻿namespace Microsoft.SpeechServices.VideoTranslation.DataContracts.DTOs;

using System;
using System.Collections.Generic;
using Microsoft.SpeechServices.Common.Client;
using Microsoft.SpeechServices.CommonLib.Enums;
using Microsoft.SpeechServices.DataContracts;
using Microsoft.SpeechServices.DataContracts.Deprecated;
using Microsoft.SpeechServices.VideoTranslation.Enums;

public class TranslationBase : StatefulResourceBase
{
    public Guid VideoFileId { get; set; }

    public VideoTranslationMergeParagraphAudioAlignKind? AudioAlignKind { get; set; }

    public VideoTranslationVoiceKind? VoiceKind { get; init; }

    public string EnableFeatures { get; set; }

    public string ProfileName { get; set; }

    public bool? WithoutSubtitleInTranslatedVideoFile { get; set; }

    public bool? ExportPersonalVoicePromptAudioMetadata { get; set; }

    public bool? IsAssociatedWithTargetLocale { get; set; }

    public string PersonalVoiceModelName { get; set; }

    public VideoTranslationWebvttSourceKind? WebvttSourceKind { get; set; }

    public IReadOnlyDictionary<string, string> AdditionalProperties { get; set; }
}