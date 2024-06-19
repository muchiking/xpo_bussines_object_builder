import shutil

classname="AssetManagment"

# Specify the source file path
src_file = f'built/{classname}.cs'

# Specify the destination directory
dst_directory = 'HRM.Module/BusinessObjects'

# Copy the file to the destination directory
shutil.copy(src_file, dst_directory)