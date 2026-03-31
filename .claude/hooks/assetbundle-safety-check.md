# AssetBundle Safety Check

## Trigger
When editing bundle loading, caching, prefab instantiation, or hot-update resource code.

## Check
- are bundle name and asset name logged
- is resource version tracked
- is file integrity validated with size or hash
- is cache source visible in logs
- are unload timing and dependency versions considered

## Remind
- intermittent AB crashes often require telemetry first
- cache and dependency mismatches are common root causes
