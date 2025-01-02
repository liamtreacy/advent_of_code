package org.example;

public class Main {
    public static void main(String[] args) {
        var reader = new DayOneReader();

        System.out.println("Part One: " + DayOneCalculator.GetDistance(reader.GetL(), reader.GetR()));
        System.out.println("Part Two: " + DayOneCalculator.GetSimilarityScore(reader.GetL(), reader.GetR()));
    }
}