#!/usr/bin/env bash
# Clones SPIRV-Cross at the revision pinned in upstream.lock into ./upstream/SPIRV-Cross.
# Pass a commit / tag as first argument to try another revision (the generator is written for "latest").
set -euo pipefail
cd "$(dirname "$0")/.."
source upstream.lock
rev="${1:-$commit}"
mkdir -p upstream
if [ ! -d upstream/SPIRV-Cross/.git ]; then
    git clone "$repository" upstream/SPIRV-Cross
fi
git -C upstream/SPIRV-Cross fetch --quiet origin
git -C upstream/SPIRV-Cross checkout --quiet "$rev"
echo "SPIRV-Cross at $(git -C upstream/SPIRV-Cross rev-parse HEAD)"
