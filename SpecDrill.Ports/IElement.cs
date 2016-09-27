﻿using SpecDrill.SecondaryPorts.AutomationFramework.Core;
using SpecDrill.SecondaryPorts.AutomationFramework.Model;

namespace SpecDrill.SecondaryPorts.AutomationFramework
{
    public interface IElement
    {
        /// <summary>
        /// Native Element
        /// </summary>
        SearchResult NativeElementSearchResult { get; }

        /// <summary>
        /// Counts Occurences of element as described by locator (Ignores locator's Index property meaning it doesn't return 1 if index is specified)
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Checks if the element is in a read-only mode (read-only or disabled)
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Checks if the element is drawn on screen and ready for interaction (shown and enabled)
        /// </summary>
        bool IsAvailable { get; }

        /// <summary>
        /// Underlying Browser object responsible with browser interaction
        /// </summary>
        IBrowser Browser { get; }

        void Click();

        /// <summary>
        /// Sends text to input
        /// </summary>
        /// <param name="keys">Text to send into textbox</param>

        IElement SendKeys(string keys);

        /// <summary>
        /// Lose element focus
        /// </summary>
        /// <returns></returns>
        void Blur();

        /// <summary>
        /// Clears input
        /// </summary>
        /// <returns></returns>
        IElement Clear();

        string Text { get; }

        /// <summary>
        /// Gets html element attribute value
        /// </summary>
        /// <param name="attributeName">Element atribute's name</param>
        /// <returns>attribute value, or null if attribute not present</returns>
        string GetAttribute(string attributeName);

        string GetCssValue(string cssValueName);

        void Hover();

        IElement Parent { get; }

        IElementLocator Locator { get; }
    }
}