using System;

namespace CalculatorExample
{
    class Calculator<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public T Add(T a, T b) => (dynamic)a + b;
        public T Subtract(T a, T b) => (dynamic)a - b;
        public T Multiply(T a, T b) => (dynamic)a * b;
        public T Divide(T a, T b) => (dynamic)a / b;
    }
}