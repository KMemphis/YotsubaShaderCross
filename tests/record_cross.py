#!/usr/bin/env python3
"""Stand-in for the spirv-cross executable used while preparing the conformance cases.

Upstream's test_shaders.py knows how every shader has to be translated (file name tokens select the options).
Pointing its 'spirv-cross' path at this script records the command line it would have used; the output file is
created empty so that the surrounding script keeps going.
"""
import json, os, sys
with open(os.environ['YSC_RECORD'], 'a') as f:
    f.write(json.dumps(sys.argv[1:]) + '\n')
if '--output' in sys.argv:
    open(sys.argv[sys.argv.index('--output') + 1], 'w').close()
