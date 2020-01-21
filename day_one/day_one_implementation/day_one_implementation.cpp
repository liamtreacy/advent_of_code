#include <iostream>
#include <fstream>
#include <string>

#include "sum_frequencies.h"

void getInput(std::string& s, std::vector<int>& freqs)
{
    std::ifstream file(s);
    std::string line;
    int l = 0;
    if (file.is_open())
    {
        while (std::getline(file, line))
        {
            l = std::stoi(line);
            freqs.push_back(l);
        }
    }

    file.close();
}

int main()
{
    std::string file_name = "C:\\Users\\LTreacy\\Desktop\\input_advent.txt";
    std::vector<int> freqs;

    getInput(file_name, freqs);

    std::cout << " Sum is " << sumFreq(freqs) << "\n";

    return 0;
}
