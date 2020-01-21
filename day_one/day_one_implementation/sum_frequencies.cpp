#include "sum_frequencies.h"

int sumFreq(std::vector<int> freqs)
{
    int sum = 0;

    for (auto f : freqs)
        sum += f;

    return sum;
}
