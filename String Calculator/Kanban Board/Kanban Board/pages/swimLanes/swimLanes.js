// For an introduction to the Page Control template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232511
/// <reference path="knockout-2.0.0.js" />
(function () {
    "use strict";

    var appViewState = Windows.UI.ViewManagement.ApplicationViewState;
    var binding = WinJS.Binding;
    var nav = WinJS.Navigation;
    var ui = WinJS.UI;
    var utils = WinJS.Utilities;

    WinJS.UI.Pages.define("/pages/swimLanes/swimLanes.html", {
        ready: function (element, options) {
            var listView = element.querySelector(".itemlist").winControl;

            this._group = (options && options.groupKey) ? Data.resolveGroupReference(options.groupKey) : Data.groups.getAt(0);
            this._items = Data.getItemsFromGroup(this._group);
            this._itemSelectionIndex = (options && "selectedIndex" in options) ? options.selectedIndex : -1;

            element.querySelector("header[role=banner] .pagetitle").textContent = this._group.title;

            // Set up the ListView.
            listView.itemDataSource = this._items.dataSource;
            listView.itemTemplate = element.querySelector(".itemtemplate");
            listView.onselectionchanged = this._selectionChanged.bind(this);
            listView.layout = new ui.ListLayout();

           // this._updateVisibility();  
            
        },

       unload: function () {
            // TODO: Respond to navigations away from this page.
        },

        updateLayout: function (element, viewState, lastViewState) {
            /// <param name="element" domElement="true" />

            // TODO: Respond to changes in viewState.
        },
        
        _selectionChanged: function (args) {
        var listView = document.body.querySelector(".itemlist").winControl;
        var details;
            // By default, the selection is restriced to a single item.
        listView.selection.getItems().done(function updateDetails(items) {
            if (items.length > 0) {
                this._itemSelectionIndex = items[0].index;
                if (this._isSingleColumn()) {
                    // If snapped or portrait, navigate to a new page containing the
                    // selected item's details.
                    nav.navigate("/pages/swimLanes/swimLanes.html", { groupKey: this._group.key, selectedIndex: this._itemSelectionIndex });
                }
            }
        }.bind(this));
    }
    });
})();
