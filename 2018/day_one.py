from file_utils import read_file_to_list
from freq_sum import freq_sum

import os

def day_one():
    dir_path = os.path.dirname(os.path.realpath(__file__))
    freqs = read_file_to_list(os.path.join(dir_path,'day_one_input.txt'))
    print(freq_sum(freqs))

if __name__ == '__main__':
    day_one()
