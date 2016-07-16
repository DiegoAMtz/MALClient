﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MalClient.Shared.Utils.Enums;
using MalClient.Shared.ViewModels;

namespace MalClient.Shared.Delegates
{
    public delegate void OffContentPaneStateChanged();
    public delegate void AnimeItemListInitialized();
    public delegate void ScrollIntoViewRequest(AnimeItemViewModel item);
    public delegate void SelectionResetRequest(AnimeListDisplayModes mode);
    public delegate void SortingSettingChange(SortOptions option, bool descencing);
}
