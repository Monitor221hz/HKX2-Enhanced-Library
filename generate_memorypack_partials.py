import os, re, glob

out_dir = os.path.join('HKX2', 'MemoryPack')
os.makedirs(out_dir, exist_ok=True)

pattern = re.compile(r'public partial class (\w+)')

count = 0
for search_dir in ['HKX2/Autogen', 'HKX2/Manual']:
    for filepath in sorted(glob.glob(os.path.join(search_dir, '*.cs'))):
        with open(filepath, encoding='utf-8') as fh:
            content = fh.read()
        m = pattern.search(content)
        if m:
            classname = m.group(1)
            out_path = os.path.join(out_dir, classname + '.MemoryPack.cs')
            with open(out_path, 'w', encoding='utf-8', newline='\n') as out:
                out.write('using MemoryPack;\n')
                out.write('\n')
                out.write('namespace HKX2E;\n')
                out.write('\n')
                out.write('[MemoryPackable(GenerateType.CircularReference, SerializeLayout.Sequential)]\n')
                out.write('public partial class ' + classname + ';\n')
            count += 1

print('Generated ' + str(count) + ' partial class files in ' + out_dir)
