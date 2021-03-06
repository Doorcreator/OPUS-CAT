﻿using Sdl.Core.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FiskmoTranslationProvider
{
    public class FinetuneBatchTaskSettings : SettingsGroup, INotifyPropertyChanged, IDataErrorInfo
    {

        public string this[string columnName]
        {
            get
            {
                return Validate(columnName);
            }
        }

        public string Error
        {
            get { return "...."; }
        }

        private string Validate(string propertyName)
        {
            // Return error message if there is error on else return empty or null string
            string validationMessage = string.Empty;
            switch (propertyName)
            {
                case "MaxFinetuningSentences":
                    if (this.MaxFinetuningSentences != null && this.MaxFinetuningSentences != "")
                    {
                        var maxSent = Int32.Parse(this.MaxFinetuningSentences);
                        if (maxSent < Int32.Parse(FiskmoTpSettings.Default.FinetuningMinSentencePairs) ||
                            maxSent > Int32.Parse(FiskmoTpSettings.Default.FinetuningSentencePairsHardLimit))
                        {
                            validationMessage = "Error";
                        }
                    }
                    else
                    {
                        validationMessage = "Error";
                    }

                    break;
            }

            return validationMessage;
        }

        public new event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public bool Finetune
        {
            get
            {
                return GetSetting<bool>(nameof(Finetune));
            }
            set
            {
                GetSetting<bool>(nameof(Finetune)).Value = value;
                NotifyPropertyChanged();
            }
        }

        public bool IncludePlaceholderTags
        {
            get
            {
                return GetSetting<bool>(nameof(IncludePlaceholderTags));
            }
            set
            {
                GetSetting<bool>(nameof(IncludePlaceholderTags)).Value = value;
                NotifyPropertyChanged();
            }
        }

        public bool IncludeTagPairs
        {
            get
            {
                return GetSetting<bool>(nameof(IncludeTagPairs));
            }
            set
            {
                GetSetting<bool>(nameof(IncludeTagPairs)).Value = value;
                NotifyPropertyChanged();
            }
        }

        public bool BatchTranslate
        {
            get
            {
                return GetSetting<bool>(nameof(BatchTranslate));
            }
            set
            {
                GetSetting<bool>(nameof(BatchTranslate)).Value = value;
                NotifyPropertyChanged();
            }
        }


        public string ProviderOptions
        {
            get
            {
                var settingValue = GetSetting<string>(nameof(ProviderOptions));
                if (settingValue == null || settingValue == "")
                {
                    return (new FiskmoOptions()).Uri.ToString();
                }
                else
                {
                    return settingValue;
                }
            }
            set
            {
                GetSetting<string>(nameof(ProviderOptions)).Value = value;
                NotifyPropertyChanged();
            }
        }

        public bool AddFiskmoProvider
        {
            get
            {
                return GetSetting<bool>(nameof(AddFiskmoProvider));
            }
            set
            {
                GetSetting<bool>(nameof(AddFiskmoProvider)).Value = value;
                NotifyPropertyChanged();
            }
        }

        public bool ExtractFuzzies
        {
            get
            {
                return GetSetting<bool>(nameof(ExtractFuzzies));
            }
            set
            {
                GetSetting<bool>(nameof(ExtractFuzzies)).Value = value;
                NotifyPropertyChanged();
            }
        }

        public int FuzzyMinPercentage
        {
            get
            {
                var settingValue = GetSetting<int>(nameof(FuzzyMinPercentage));
                if (settingValue == 0)
                {
                    return FiskmoTpSettings.Default.FinetuningMinFuzzyPercentage;
                }
                else
                {
                    return settingValue;
                }

            }
            set
            {
                GetSetting<int>(nameof(FuzzyMinPercentage)).Value = value;
                NotifyPropertyChanged();
            }
        }

        public int FuzzyMaxResults
        {
            get
            {
                var settingValue = GetSetting<int>(nameof(FuzzyMaxResults));
                if (settingValue == 0)
                {
                    return FiskmoTpSettings.Default.FinetuningMaxFuzzyResults;
                }
                else
                {
                    return settingValue;
                }
            }
            set
            {
                GetSetting<int>(nameof(FuzzyMaxResults)).Value = value;
                NotifyPropertyChanged();
            }
        }

        public string MaxFinetuningSentences
        {
            get
            {
                var settingValue = GetSetting<string>(nameof(MaxFinetuningSentences));
                if (settingValue == null || settingValue == "")
                {
                    return FiskmoTpSettings.Default.FinetuningMaxSentencePairs;
                }
                else
                {
                    return settingValue;
                }
            }
            set
            {
                GetSetting<string>(nameof(MaxFinetuningSentences)).Value = value;
                NotifyPropertyChanged();
            }
        }


    }
}
