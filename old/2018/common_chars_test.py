import unittest

from common_chars import get_common_chars

class MyTestCase(unittest.TestCase):
    def test_something(self):
        self.assertEqual(get_common_chars(['a', 'b', 'c']), '')

    def test_something1(self):
        self.assertEqual(get_common_chars(['abc', 'abd', 'abb']), 'ab')

    def test_something9(self):
        self.assertEqual(get_common_chars(['abcde', 'abdde', 'adecb']), 'abde')

if __name__ == '__main__':
    unittest.main()
