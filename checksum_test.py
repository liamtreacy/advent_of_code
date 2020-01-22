import unittest

from checksum import get_checksum

class MyTestCase(unittest.TestCase):
    def test_something(self):
        self.assertEqual(get_checksum(['a']), 0)

    def test_one_double(self):
        self.assertEqual(get_checksum(['aa','b']), 0)

    def test_two_doubles(self):
        self.assertEqual(get_checksum(['aa','dd']), 0)

    def test_one_triple(self):
        self.assertEqual(get_checksum(['a','bbb']), 0)

    def test_two_triple(self):
        self.assertEqual(get_checksum(['eee','bbb', 'c']), 0)

    def test_triple_and_double(self):
        self.assertEqual(get_checksum(['ee','bbb', 'c']), 1)

    def test_mix(self):
        self.assertEqual(get_checksum(['f', 'ee','bbb', 'pp', 'fff', 'c']), 4)

    def test_bigger_mix(self):
        self.assertEqual(get_checksum(['f', 'ee','bbb', 'pp', 'fff', 'c', 'ddd', 'qiee', 'poppld', 'hjhjhjhj', 'qqbq']), 15)

if __name__ == '__main__':
    unittest.main()
