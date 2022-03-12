# Lcl.ProtoTemplates
My collection of prototype projects to be turned into
Visual Studio "project templates".

For more information on VS project templates, see:
* [How To: Create project templates](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-create-project-templates?view=vs-2022)
* [Template parameters](https://docs.microsoft.com/en-us/visualstudio/ide/template-parameters?view=vs-2022)
* [Template tags](https://docs.microsoft.com/en-us/visualstudio/ide/template-tags?view=vs-2022)


## Usage

You can create a preliminary version of a working template by selecting
the project and then select "Export Template..." from the project menu
(note that that command is not present in the project's right-click menu).

The template wizard will create a template (a zip file) and generate a
*.vstemplate file inside it. That *.vstemplate file needs a bit of editing
though, I recommend _not_ let the wizard install the template just yet.
Instead replace the generated *.vstemplate file inside the zip file with
the one I added in the solution folder (with a name matching the project,
e.g. LclFsNet6.vstemplate). Copy the final zip file to your project templates
folder (check visual studio's option dialog for its location).
Close visual studio and re-open it and hopefully the new template shows up.

### Troubleshooting

Visual Studio is a bit picky in recognizing new templates, and even more
picky in noticing changes in templates.

Tip 1:

Reminder in case templates do not show up after packaging them and
putting them in the template folder: consider running the following
magical incantation _in an elevated VS Command Prompt_ (source:
[https://stackoverflow.com/a/1717537/271323](https://stackoverflow.com/a/1717537/271323) ) :

    devenv /installvstemplates

Tip 2:

If you seem to be stuck with an older version of a template that refuses
to update, it is useful to realize that VS unpacks the template zip file
into a _cache_ folder. Consider editing the template inside that cache folder
to fix the issue (or remove it from the cache to trigger a reinstall).
The cache folder seems to be located in:

    %USERPROFILE%\AppData\Roaming\Microsoft\VisualStudio\<tag>\ProjectTemplatesCache

where _\<tag>_ describes the visual studio version plus an additional series of
characters. For example, for my VS2022 installation it was _17.0_c2daef97_.
 
## Templates
* LclFsNet6: F# console template for use with .net6
  
  The latest version of my much-used F# console application template.

  * Intended for use with .NET6 and VS2022.
  * Includes a Exception catcher and pretty-printer
  * Includes "verbosity" flag support for use in your application;
    it is also used by the exception handler
  * Includes a stub for a command line parser
  * Includes a framework for help/usage message
  * Includes a module to make it simpler and more compact to write
    colored text to the console. See the comments in ColorPrint.fs
    for notes on usage.














