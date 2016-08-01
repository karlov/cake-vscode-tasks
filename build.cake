var target = Argument("target", "Default");

Task("default")
    .Does(() => {
        Information("working");
    });

RunTarget(target);