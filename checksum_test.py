import unittest

# Get the number of entries with exactly two matching characters
def get_two(strings):
    count = 0
    for s in strings:

        for i in range(0, len(s)):
            print(s)
            print(s[i])
            print(s.count(str(s[i])))
            print('----')
            if s.count(str([i])) is 2:
                count += 1

    return count




class MyTestCase(unittest.TestCase):
    def test_something(self):
        self.assertEqual(get_two(['a']), 0)

    def test_one_double(self):
        self.assertEqual(get_two(['aa','b']), 1)

if __name__ == '__main__':
    unittest.main()
