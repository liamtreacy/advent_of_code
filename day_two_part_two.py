from file_utils import read_file_to_list
from common_chars import get_common_chars

import os

def day_two_pt():
    dir_path = os.path.dirname(os.path.realpath(__file__))
    strings = read_file_to_list(os.path.join(dir_path,'day_two_part_two.txt'))
    print(get_common_chars(strings))

if __name__ == '__main__':
    day_two_pt()