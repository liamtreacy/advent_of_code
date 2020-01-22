import unittest

def freq_sum(freqs) :
    sum = 0

    for f in freqs:
        sum += f

    return sum

class MyTestCase(unittest.TestCase):
    def test_two_vals(self):
        freqs = [1, 0, 1]
        self.assertEqual(freq_sum(freqs), 2)

    def test_negative_vals(self):
        freqs = [-1, -2, -1]
        self.assertEqual(freq_sum(freqs), -4)

    def test_mixed_vals(self):
        freqs = [-1, -2, 5, 6, -3, 4]
        self.assertEqual(freq_sum(freqs), 9)


if __name__ == '__main__':
    unittest.main()
