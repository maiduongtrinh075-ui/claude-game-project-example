# AssetBundle Debugging

## Purpose
Use this skill to investigate intermittent crashes or corruption when loading UI or prefabs from AssetBundles.

## When To Use
- Android or iOS crashes during prefab instantiation
- logs mention corrupted files, serialization, or out-of-bounds reads
- crashes happen only sometimes
- resources are loaded from AssetBundles or hot-update packages

## Read First
- `CLAUDE.md`
- `docs/guide.zh-CN.md`
- `src/ui/battle/CLAUDE.md` if the issue is combat UI
- the owning prefab loader such as `UIPrefabsManager`

## Steps
1. Identify the exact `bundleName`, `assetName`, and call chain.
2. Add a request id so one load flow can be tracked across logs.
3. Log file path, file size, version, hash, cache source, and instantiate timing.
4. Verify the prefab and its dependencies are from the same resource version.
5. Check whether the prefab's attached scripts changed serialized fields recently.
6. Check for duplicate loads, premature unloads, or race conditions.
7. Re-test with cache cleared to separate cache corruption from logic issues.

## Common Causes
- stale cached bundle after code or prefab changes
- incomplete or corrupted downloaded bundle
- dependency bundle mismatch
- prefab serialization layout changed between versions
- parallel load and unload timing problems

## Do Not Do
- do not call the issue fixed without recording bundle version and cache state
- do not assume null checks alone will solve native instantiate crashes
- do not keep reusing suspicious cached bundles without hash validation

## Output
Produce:
- suspected root causes
- exact bundle and asset under suspicion
- missing telemetry or logs to add
- next verification steps
