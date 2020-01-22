from file_utils import read_file_to_list
from freq_sum import freq_sum

import os

desktop = os.path.join(os.path.join(os.environ['USERPROFILE'], 'Desktop'))
l = read_file_to_list(os.path.join(desktop,'input_advent.txt'))
print(freq_sum(l))
