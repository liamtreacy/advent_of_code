package org.example;

public class Main {
    public static void main(String[] args) {
        var reader = new DayOneReader();

        System.out.println(DayOneCalculator.calc(reader.GetL(), reader.GetR()));
    }
}