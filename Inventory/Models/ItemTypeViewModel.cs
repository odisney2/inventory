﻿/*
    Orris Disney II
    C# Inventory Project
    July 2018
    
    Definition of a Model
    The model represents the data, and does nothing else. The model does NOT depend on the controller or the view. 
    The view displays the model data, and sends user actions (e.g. button clicks) to the controller.

    Definition of a ViewModel
    It is a model class that can hold only those properties that is required for a view. 
    ViewModels allow you to shape multiple entities from one or more data models or sources into a single object, 
    optimized for consumption and rendering by the view.

    This is for the the Item Types part of the project.  Got ItemTypeView Model setup as a List of Item Types.  
    This is where you setup what data we are gathering and/or in case of getting more information about the class Item itself 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Inventory.Models
{
    public class ItemTypeViewModel
    {
        /* the ? allows this to be null */
        public int? ItemTypeId { get; set; }

        [DisplayName("Item Type Information")]
        public string ItemTypeDisplayName { get; set; }

        [DisplayName("Item Type Notes")]
        public string ItemTypeNotes { get; set; }

        [DisplayName("Item Type Full Info")]
        public string ItemTypeFullInfo => ItemTypeDisplayName + " " + ItemTypeNotes;
    }
}