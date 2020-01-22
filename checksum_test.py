import unittest

# Get the number of entries with exactly two matching characters
def get_checksum(strings):
    two_count = 0
    three_count = 0

    for s in strings:
        found_two = False
        found_three = False

        for i in range(0, len(s)):

            if s.count(str(s[i])) is 2:
                found_two = True
            if s.count(str(s[i])) is 3:
                found_three = True

        if found_two is True:
            two_count += 1
            found_two = False
        if found_three is True:
            three_count +=1
            found_three = False

    return two_count*three_count




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
