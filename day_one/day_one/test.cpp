#include "gtest/gtest.h"

#include <vector>

int sumFreq(std::vector<int> freqs)
{
    return freqs[0];
}

TEST(SumFrequencies, zero) 
{
    EXPECT_EQ(sumFreq({ 0 }), 0);
}

TEST(SumFrequencies, one)
{
    EXPECT_EQ(sumFreq({ 1 }), 1);
}