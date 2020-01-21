#include "gtest/gtest.h"

#include <vector>

int sumFreq(std::vector<int> freqs)
{
    int sum = 0;

    for (auto f : freqs)
        sum += f;

    return sum;
}

TEST(SumFrequencies, zero) 
{
    EXPECT_EQ(sumFreq({ 0 }), 0);
}

TEST(SumFrequencies, one)
{
    EXPECT_EQ(sumFreq({ 1 }), 1);
}

TEST(SumFrequencies, two_values)
{
    EXPECT_EQ(sumFreq({ 0, 1 }), 1);
}

TEST(SumFrequencies, multiple_values)
{
    EXPECT_EQ(sumFreq({ 0, 1, -3, 7, -2, 0, 11, 8 }), 22);
}