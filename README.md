# What is this?
It's a repo to demonstrate what I think is a bug in the latest 6.0 SDKs with Code Analysis.
The project targets `net5.0` and has the 'opt-out' setting for code analysis (`<AnalysisMode>AllEnabledByDefault</AnalysisMode>`)

If built with a 6.0 SDK, **there are no code analysis errors** produced with `dotnet build`

**BUT...**  If locked to a 5.0 SDK with a `global.json`, then code analysis errors **are** produced.

To reproduce, run `dotnet build` on this repo and observe errors.  Then delete `global.json` to force it to use a 6.0 SDK, and rebuild and observe no code analysis results.
