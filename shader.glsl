#version 450
layout(local_size_x = 1, local_size_y = 1, local_size_z = 1) in;

uint foo(int a, float b)
{
    return uint(float(a) + b);
}

void main()
{
    int a = 7;
    float b = 8.0;
    int param = a;
    float param_1 = b;
    uint c = foo(param, param_1);
}

