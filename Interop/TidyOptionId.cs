// Copyright (c) 2009 Mark Beaton
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

using System;

namespace TidyManaged.Interop
{
	internal enum TidyOptionId
	{
		TidyUnknownOption = 0,    /*< Unknown option! */
		TidyIndentSpaces = 1,     /*< Indentation n spaces */
		TidyWrapLen = 2,          /*< Wrap margin */
		TidyTabSize = 3,          /*< Expand tabs to n spaces */
		TidyCharEncoding = 4,     /*< In/out character encoding */
		TidyInCharEncoding = 5,   /*< Input character encoding (if different) */
		TidyOutCharEncoding = 6,  /*< Output character encoding (if different) */
		TidyNewline = 7,          /*< Output line ending (default to platform) */
		TidyDoctypeMode = 8,      /*< See doctype property */
		TidyDoctype = 9,          /*< User specified doctype */
		TidyDuplicateAttrs = 10,  /*< Keep first or last duplicate attribute */
		TidyAltText = 11,         /*< Default text for alt attribute */

		[Obsolete]
		TidySlideStyle = 12,      /*< Style sheet for slides: not used for anything yet */

		TidyErrFile = 13,         /*< File name to write errors to */
		TidyOutFile = 14,         /*< File name to write markup to */
		TidyWriteBack = 15,       /*< If true then output tidied markup */
		TidyShowMarkup = 16,      /*< If false, normal output is suppressed */
		TidyShowInfo = 17,        /*< If true, info-level messages are shown */
		TidyShowWarnings = 18,    /*< However errors are always shown */
		TidyQuiet = 19,           /*< No 'Parsing X', guessed DTD or summary */
		TidyIndentContent = 20,   /*< Indent content of appropriate tags */
		/*< "auto" does text/block level content indentation */
		TidyCoerceEndTags = 21,   /*< Coerce end tags from start tags where probably intended */
		TidyOmitOptionalTags = 22,/*< Suppress optional start tags and end tags */
		TidyHideEndTags = 23,     /*< Suppress optional end tags */
		TidyXmlTags = 24,         /*< Treat input as XML */
		TidyXmlOut = 25,          /*< Create output as XML */
		TidyXhtmlOut = 26,        /*< Output extensible HTML */
		TidyHtmlOut = 27,         /*< Output plain HTML, even for XHTML input.
                           Yes means set explicitly. */
		TidyXmlDecl = 28,         /*< Add <?xml?> for XML docs */
		TidyUpperCaseTags = 29,   /*< Output tags in upper not lower case */
		TidyUpperCaseAttrs = 30,  /*< Output attributes in upper not lower case */
		TidyMakeBare = 31,        /*< Make bare HTML: remove Microsoft cruft */
		TidyMakeClean = 32,       /*< Replace presentational clutter by style rules */
		TidyGDocClean = 33,       /*< Clean up HTML exported from Google Docs */
		TidyLogicalEmphasis = 34, /*< Replace i by em and b by strong */
		TidyDropPropAttrs = 35,   /*< Discard proprietary attributes */
		TidyDropFontTags = 36,    /*< Discard presentation tags */
		TidyDropEmptyElems = 37,  /*< Discard empty elements */
		TidyDropEmptyParas = 38,  /*< Discard empty p elements */
		TidyFixComments = 39,     /*< Fix comments with adjacent hyphens */
		TidyBreakBeforeBR = 40,   /*< Output newline before <br> or not? */

		[Obsolete]
		TidyBurstSlides = 41,     /*< Create slides on each h2 element */

		TidyNumEntities = 42,     /*< Use numeric entities */
		TidyQuoteMarks = 43,      /*< Output " marks as &quot; */
		TidyQuoteNbsp = 44,       /*< Output non-breaking space as entity */
		TidyQuoteAmpersand = 45,  /*< Output naked ampersand as &amp; */
		TidyWrapAttVals = 46,     /*< Wrap within attribute values */
		TidyWrapScriptlets = 47,  /*< Wrap within JavaScript string literals */
		TidyWrapSection = 48,     /*< Wrap within <![ ... ]> section tags */
		TidyWrapAsp = 49,         /*< Wrap within ASP pseudo elements */
		TidyWrapJste = 50,        /*< Wrap within JSTE pseudo elements */
		TidyWrapPhp = 51,         /*< Wrap within PHP pseudo elements */
		TidyFixBackslash = 52,    /*< Fix URLs by replacing \ with / */
		TidyIndentAttributes = 53,/*< Newline+indent before each attribute */
		TidyXmlPIs = 54,          /*< If set to yes PIs must end with ?> */
		TidyXmlSpace = 55,        /*< If set to yes adds xml:space attr as needed */
		TidyEncloseBodyText = 56, /*< If yes text at body is wrapped in P's */
		TidyEncloseBlockText = 57,/*< If yes text in blocks is wrapped in P's */
		TidyKeepFileTimes = 58,   /*< If yes last modied time is preserved */
		TidyWord2000 = 59,        /*< Draconian cleaning for Word2000 */
		TidyMark = 60,            /*< Add meta element indicating tidied doc */
		TidyEmacs = 61,           /*< If true format error output for GNU Emacs */
		TidyEmacsFile = 62,       /*< Name of current Emacs file */
		TidyLiteralAttribs = 63,  /*< If true attributes may use newlines */
		TidyBodyOnly = 64,        /*< Output BODY content only */
		TidyFixUri = 65,          /*< Applies URI encoding if necessary */
		TidyLowerLiterals = 66,   /*< Folds known attribute values to lower case */
		TidyHideComments = 67,    /*< Hides all (real) comments in output */
		TidyIndentCdata = 68,     /*< Indent <!CDATA[ ... ]]> section */
		TidyForceOutput = 69,     /*< Output document even if errors were found */
		TidyShowErrors = 70,      /*< Number of errors to put out */
		TidyAsciiChars = 71,      /*< Convert quotes and dashes to nearest ASCII char */
		TidyJoinClasses = 72,     /*< Join multiple class attributes */
		TidyJoinStyles = 73,      /*< Join multiple style attributes */
		TidyEscapeCdata = 74,     /*< Replace <![CDATA[]]> sections with escaped text */
#if SUPPORT_ASIAN_ENCODINGS
		TidyLanguage = 75,        /*< Language property: not used for anything yet */
		TidyNCR = 76,             /*< Allow numeric character references */
#endif
#if SUPPORT_UTF16_ENCODINGS
		TidyOutputBOM = 77,      /*< Output a Byte Order Mark (BOM) for UTF-16 encodings */
		                    /*< auto: if input stream has BOM, we output a BOM */
#endif
		TidyReplaceColor = 78,    /*< Replace hex color attribute values with names */
		TidyCSSPrefix = 79,       /*< CSS class naming for -clean option */
		TidyInlineTags = 80,      /*< Declared inline tags */
		TidyBlockTags = 81,       /*< Declared block tags */
		TidyEmptyTags = 82,       /*< Declared empty tags */
		TidyPreTags = 83,         /*< Declared pre tags */
		TidyAccessibilityCheckLevel = 84, /*< Accessibility check level
                                   0 (old style), or 1, 2, 3 */
		TidyVertSpace = 85,       /*< degree to which markup is spread out vertically */
#if SUPPORT_ASIAN_ENCODINGS
		TidyPunctWrap = 86,       /*< consider punctuation and breaking spaces for wrapping */
#endif
		TidyMergeEmphasis = 87,       /*< Merge nested B and I elements */
		TidyMergeDivs = 88,           /*< Merge multiple DIVs */
		TidyDecorateInferredUL = 89,  /*< Mark inferred UL elements with no indent CSS */
		TidyPreserveEntities = 90,    /*< Preserve entities */
		TidySortAttributes = 91,      /*< Sort attributes */
		TidyMergeSpans = 92,       /*< Merge multiple SPANs */
		TidyAnchorAsName = 93,    /*< Define anchors as name attributes */
		N_TIDY_OPTIONS       /*< Must be last */
	}
}
