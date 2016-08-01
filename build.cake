var target = Argument("target", "Default");

Task("test")
    .Description("Do something very special with a lot of multi line description stuff etc. and go on and on and on.")
    .Does(() => {
        Information("working");
    });

Task("default")
    .Does(() => {
        Information("working");
    });

RunTarget(target);