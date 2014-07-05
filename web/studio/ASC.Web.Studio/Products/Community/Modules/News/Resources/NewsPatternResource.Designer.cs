/*
(c) Copyright Ascensio System SIA 2010-2014

This program is a free software product.
You can redistribute it and/or modify it under the terms 
of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of 
any third-party rights.

This program is distributed WITHOUT ANY WARRANTY; without even the implied warranty 
of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see 
the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html

You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.

The  interactive user interfaces in modified source and object code versions of the Program must 
display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
 
Pursuant to Section 7(b) of the License you must retain the original Product logo when 
distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under 
trademark law for use of our trademarks.
 
All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode
*/

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASC.Web.Community.News.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class NewsPatternResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NewsPatternResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ASC.Web.Community.News.Resources.NewsPatternResource", typeof(NewsPatternResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h1.#if($FEED_TYPE == &quot;feed&quot;)New Event: &quot;$Caption&quot;:&quot;$URL&quot;
        ///
        ///$Date &quot;$UserName&quot;:&quot;$UserURL&quot; has added a new event:
        ///
        ///$Text
        ///
        ///&quot;Read more&quot;:&quot;$URL&quot;
        ///
        ///#end#if($FEED_TYPE == &quot;poll&quot;)New Poll: &quot;$Caption&quot;:&quot;$URL&quot;
        ///
        ///$Date &quot;$UserName&quot;:&quot;$UserURL&quot; has added a new poll:
        ///
        ///#foreach($Answer in $Answers)
        ///
        ///#each
        ///
        ///* $Answer
        ///
        ///#end
        ///
        ///&quot;Vote&quot;:&quot;$URL&quot;
        ///
        ///#end
        ///
        ///Your portal address: &quot;$__VirtualRootPath&quot;:&quot;$__VirtualRootPath&quot;
        ///
        ///&quot;Edit subscription settings&quot;:&quot;$RecipientSubscriptionConfigURL&quot;.
        /// </summary>
        internal static string pattern_new_text {
            get {
                return ResourceManager.GetString("pattern_new_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h1.#if($FEED_TYPE == &quot;poll&quot;)New Comment to Poll#end#if($FEED_TYPE == &quot;feed&quot;)New Comment to Event#end: &quot;$Caption&quot;:&quot;$URL&quot;
        ///
        ///&quot;$UserName&quot;:&quot;$UserURL&quot; $Date
        ///
        ///$CommentBody
        ///
        ///&quot;Read More&quot;:&quot;$CommentURL&quot;
        ///
        ///Your portal address: &quot;$__VirtualRootPath&quot;:&quot;$__VirtualRootPath&quot;
        ///
        ///&quot;Edit subscription settings&quot;:&quot;$RecipientSubscriptionConfigURL&quot;.
        /// </summary>
        internal static string pattern_new_text_comment {
            get {
                return ResourceManager.GetString("pattern_new_text_comment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Community. #if($FEED_TYPE == &quot;poll&quot;)New Poll Added#end#if($FEED_TYPE == &quot;feed&quot;)New Event Added#end: $Caption.
        /// </summary>
        internal static string subject_new_text {
            get {
                return ResourceManager.GetString("subject_new_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Community. #if($FEED_TYPE == &quot;poll&quot;)New Comment to Poll#end#if($FEED_TYPE == &quot;feed&quot;)New Comment to Event#end: $Caption.
        /// </summary>
        internal static string subject_new_text_comment {
            get {
                return ResourceManager.GetString("subject_new_text_comment", resourceCulture);
            }
        }
    }
}