# AssetBundle Incident Workflow

## Use When
Use this workflow when AssetBundle loading or instantiation crashes intermittently or appears corrupted.

## Steps
1. Capture bundle name, asset name, and call chain.
2. Capture resource version, local file path, file size, and hash if available.
3. Determine whether the asset came from cache or a fresh download.
4. Add request-scoped logs around load and instantiate.
5. Check bundle dependency version consistency.
6. Check for premature unload or parallel load timing.
7. Check recent prefab serialization changes.
8. Re-test with cache cleared to isolate cache corruption.

## Output
- suspected bundle or prefab
- version and cache state
- missing telemetry
- next validation step
