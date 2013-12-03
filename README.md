# TidyManaged

This is a managed .NET/Mono wrapper for the open source, cross-platform Tidy library, a HTML/XHTML/XML markup parser & cleaner originally created by Dave Raggett.

I'm not going to explain Tidy's "raison d'être" - please read [Dave Raggett's original web page](http://www.w3.org/People/Raggett/tidy/) for more information, or the [SourceForge project](http://tidy.sourceforge.net/) that has taken over maintenance of the library.

## libtidy

This wrapper is written in C#, and makes use of .NET platform invoke (p/invoke) functionality to interoperate with the Tidy library "libtidy" (written in portable ANSI C).

Due to the way options are implemented in the Tidy library only certain versions of libtidy will work with this version of TidyManaged. The source code for libtidy is included as a git submodule and can easily be built.

## Compiling

If you are building from Git, make sure that you initialize the submodules that are part of this repository by executing: `git submodule update --init --recursive`

Then build libtidy and TidyManaged by running: `msbuild build.proj` (or on Linux: `xbuild build.proj`).

Once you have libtidy in your libs subdirectory you can open the solution in Visual Studio or MonoDevelop and compile there.

## Sample Usage

Here's a quick'n'dirty example using a simple console app.
Note: always remember to .Dispose() of your Document instance (or wrap it in a "using" statement), so the interop layer can clean up any unmanaged resources (memory, file handles etc) when it's done cleaning.

    using System;
    using TidyManaged;

    public class Test
    {
      public static void Main(string[] args)
      {
        using (Document doc = Document.FromString("<hTml><title>test</tootle><body>asd</body>"))
        {
          doc.ShowWarnings = false;
          doc.Quiet = true;
          doc.OutputXhtml = true;
          doc.CleanAndRepair();
          string parsed = doc.Save();
          Console.WriteLine(parsed);
        }
      }
    }

results in:

    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
        "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
    <meta name="generator" content=
    "HTML Tidy for Mac OS X (vers 31 October 2006 - Apple Inc. build 13), see www.w3.org" />
    <title>test</title>
    </head>
    <body>
    asd
    </body>
    </html>

## The API

At this stage I've just created a basic mapping of each of the configuration options made available by Tidy to properties of the main Document object - I've renamed a few things here & there, but it should be pretty easy to figure out what each property does (the documentation included in the code includes the original Tidy option name for each property). You can read the [Tidy configuration documentation here](http://tidy.sourceforge.net/docs/quickref.html).

## The Future

At some point I'll add a nicer ".NET-style" API layer over the top, as it's a bit clunky (although perfectly usable) at the moment.
