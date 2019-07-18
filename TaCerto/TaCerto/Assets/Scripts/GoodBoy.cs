﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//[ExecuteInEditMode]
public class GoodBoy : MonoBehaviour{
    /*public bool good = true;
    [MenuItem("GameObject/3D Object/GoodBoy", false, 10)]
    static void CreateDog(MenuCommand menuCommand){
        GameObject go = new GameObject("GoodBoy");
        double[] vx = { -0.493, -0.497, -0.521, -0.466, -0.372, -0.431, -0.413, -0.508, -0.442, -0.521, -0.521, -0.497, -0.521, -0.431, -0.413, -0.372, -0.466, -0.493, -0.521, -0.421, -0.356, -0.307, -0.284, -0.270, -0.220, -0.366, -0.316, -0.133, -0.126, -0.300, -0.357, -0.357, -0.357, -0.378, -0.296, -0.357, -0.296, -0.285, -0.273, -0.273, -0.348, -0.349, -0.349, -0.302, -0.330, -0.258, -0.297, -0.296, -0.277, -0.295, -0.276, -0.270, -0.255, -0.270, -0.208, -0.220, -0.277, -0.276, -0.295, -0.330, -0.302, -0.349, -0.297, -0.296, -0.357, -0.357, -0.348, -0.349, -0.366, -0.356, -0.307, -0.284, -0.270, -0.316, -0.133, -0.126, -0.300, -0.126, 0.036, 0.036, 0.036, -0.327, -0.263, -0.263, -0.263, -0.340, -0.372, -0.153, -0.248, -0.205, -0.189, -0.130, 0.031, -0.177, -0.156, -0.147, -0.202, -0.237, -0.190, -0.236, 0.034, 0.203, 0.247, 0.269, 0.372, 0.214, 0.292, 0.365, 0.366, 0.428, 0.329, 0.366, 0.466, 0.463, 0.437, 0.403, 0.456, 0.461, 0.403, 0.269, 0.360, 0.401, 0.269, 0.329, 0.401, 0.420, 0.247, 0.401, 0.420, 0.420, 0.465, 0.465, 0.465, 0.521, 0.521, 0.521, 0.366, 0.366, 0.372, 0.203, 0.214, 0.292, 0.365, 0.428, 0.034, 0.031, -0.130, -0.153, 0.466, 0.463, 0.437, 0.403, 0.456, 0.403, 0.461, -0.263, -0.248, -0.205, -0.189, -0.177, -0.156, -0.147, -0.202, -0.237, -0.236, -0.190, -0.372, -0.263, -0.380, -0.466, -0.466, -0.473, -0.493, -0.493, -0.507, -0.521, -0.521, -0.521, -0.248, -0.248, -0.086, -0.153, -0.153, -0.205, -0.205, -0.189, -0.189, -0.202, -0.202, -0.236, -0.236, -0.130, -0.248, -0.248, -0.205, -0.205, -0.189, -0.189, -0.202, -0.202, -0.236, -0.236, -0.153, -0.153, -0.130, 0.031, 0.031, 0.031, 0.117, 0.203, 0.203, 0.214, 0.214, 0.214, 0.292, 0.292, 0.292, 0.292, 0.428, 0.428, 0.428, 0.437, 0.437, 0.428, 0.437, 0.437, 0.465, 0.520, 0.521, 0.390, 0.447, 0.420, 0.401, 0.366, 0.329, 0.520, 0.521, 0.521, 0.520, 0.520, 0.521, 0.447, 0.520, 0.520, 0.447, 0.390, 0.447, 0.520, 0.390, 0.390, 0.366, 0.366, 0.366, 0.366, 0.366, 0.372, 0.366, 0.366, 0.372, 0.365, 0.372, 0.366, 0.365, 0.365, 0.365, 0.463, 0.463, 0.463, 0.463, 0.466, 0.466, 0.466, 0.466, 0.461, 0.461, 0.461, 0.456, 0.456, 0.461, 0.456, 0.456, 0.456, 0.403, 0.403, 0.456, 0.403, 0.403, 0.403, 0.403, 0.403, 0.437, 0.437, 0.403, -0.156, -0.153, -0.153, -0.156, -0.147, -0.147, -0.177, -0.177, -0.190, -0.190, -0.237, -0.237, -0.237, -0.236, -0.236, -0.237, -0.202, -0.237, -0.236, -0.177, -0.190, -0.189, -0.156, -0.147, -0.205, -0.248, -0.153, 0.437, 0.403, 0.403, 0.461, 0.456, 0.428, 0.466, 0.365, 0.463, 0.292, 0.372, 0.214, -0.278, -0.307, -0.284, -0.303, -0.348, -0.356, -0.366, -0.349, -0.349, -0.330, -0.295, -0.276, -0.270, -0.284, 0.390, 0.520, 0.447, 0.465, 0.521, 0.420, 0.401, 0.366, 0.329, 0.456, 0.403, 0.456, 0.403, 0.403, 0.403, 0.403, 0.403, 0.403, 0.437, 0.403, 0.437, -0.153, -0.156, -0.153, -0.156, -0.147, -0.147, -0.177, -0.177, -0.190, -0.190, -0.237, -0.237, -0.237, -0.236, -0.237, -0.236, -0.156, -0.177, -0.147, -0.189, -0.205, -0.248, -0.153, -0.202, -0.237, -0.190, -0.236, 0.365, 0.466, 0.463, 0.428, 0.461, 0.292, 0.372, 0.214, 0.437, 0.403, 0.456, 0.403, -0.307, -0.278, -0.284, -0.303, -0.348, -0.356, -0.366, -0.349, -0.349, -0.330, -0.295, -0.276, -0.270, -0.284 };
        double[] vy = { 0.245, 0.282, 0.270, 0.221, 0.207, 0.296, 0.333, 0.292, 0.310, 0.270, 0.270, 0.282, 0.270, 0.296, 0.333, 0.207, 0.221, 0.245, 0.270, 0.346, 0.332, 0.327, 0.293, 0.298, 0.228, 0.339, 0.134, 0.080, 0.157, 0.033, 0.355, 0.353, 0.355, 0.377, 0.347, 0.355, 0.347, 0.370, 0.304, 0.304, 0.323, 0.322, 0.296, 0.306, 0.278, 0.324, 0.347, 0.347, 0.269, 0.255, 0.269, 0.298, 0.318, 0.298, 0.243, 0.228, 0.269, 0.269, 0.255, 0.278, 0.306, 0.296, 0.347, 0.347, 0.355, 0.353, 0.323, 0.322, 0.339, 0.332, 0.327, 0.293, 0.298, 0.134, 0.080, 0.157, 0.033, 0.180, 0.118, 0.118, 0.141, 0.033, -0.033, -0.033, -0.033, 0.121, 0.207, -0.131, -0.106, -0.218, -0.299, -0.101, -0.088, -0.360, -0.214, -0.299, -0.350, -0.377, -0.377, -0.362, 0.070, -0.073, 0.058, 0.102, -0.069, -0.095, -0.155, -0.131, 0.003, -0.267, 0.081, 0.003, -0.341, -0.250, -0.343, -0.360, -0.376, -0.365, -0.376, 0.125, 0.081, 0.032, 0.102, 0.081, 0.032, -0.050, 0.058, 0.032, -0.050, -0.050, -0.126, -0.126, -0.126, -0.169, -0.169, -0.169, 0.003, 0.003, -0.069, -0.073, -0.095, -0.155, -0.131, -0.267, 0.070, -0.088, -0.101, -0.131, -0.341, -0.250, -0.343, -0.360, -0.376, -0.376, -0.365, -0.033, -0.106, -0.218, -0.299, -0.360, -0.214, -0.299, -0.350, -0.377, -0.362, -0.377, 0.207, -0.033, 0.189, 0.221, 0.221, 0.210, 0.245, 0.245, 0.236, 0.270, 0.270, 0.270, -0.106, -0.106, -0.140, -0.131, -0.131, -0.218, -0.218, -0.299, -0.299, -0.350, -0.350, -0.362, -0.362, -0.101, -0.106, -0.106, -0.218, -0.218, -0.299, -0.299, -0.350, -0.350, -0.362, -0.362, -0.131, -0.131, -0.101, -0.117, -0.088, -0.088, -0.073, -0.073, -0.073, -0.095, -0.095, -0.095, -0.155, -0.155, -0.155, -0.155, -0.267, -0.267, -0.267, -0.343, -0.343, -0.267, -0.343, -0.343, -0.126, -0.181, -0.169, -0.058, -0.149, -0.050, 0.032, 0.003, 0.081, -0.181, -0.169, -0.169, -0.181, -0.181, -0.169, -0.149, -0.181, -0.181, -0.149, -0.058, -0.149, -0.181, -0.058, -0.058, 0.003, 0.003, 0.003, 0.003, 0.003, -0.069, 0.003, 0.003, -0.069, -0.131, -0.069, 0.003, -0.131, -0.131, -0.131, -0.250, -0.250, -0.250, -0.250, -0.341, -0.341, -0.341, -0.341, -0.365, -0.365, -0.365, -0.376, -0.376, -0.365, -0.376, -0.376, -0.376, -0.376, -0.376, -0.376, -0.376, -0.360, -0.360, -0.376, -0.360, -0.343, -0.343, -0.360, -0.214, -0.131, -0.131, -0.214, -0.299, -0.299, -0.360, -0.360, -0.377, -0.377, -0.377, -0.377, -0.377, -0.362, -0.362, -0.377, -0.350, -0.377, -0.362, -0.360, -0.377, -0.299, -0.214, -0.299, -0.218, -0.106, -0.131, -0.343, -0.376, -0.360, -0.365, -0.376, -0.267, -0.341, -0.131, -0.250, -0.155, -0.069, -0.095, 0.268, 0.327, 0.293, 0.304, 0.321, 0.332, 0.339, 0.322, 0.296, 0.278, 0.255, 0.269, 0.298, 0.293, -0.058, -0.181, -0.149, -0.126, -0.169, -0.050, 0.032, 0.003, 0.081, -0.376, -0.376, -0.376, -0.376, -0.376, -0.360, -0.376, -0.360, -0.360, -0.343, -0.360, -0.343, -0.131, -0.214, -0.131, -0.214, -0.299, -0.299, -0.360, -0.360, -0.377, -0.377, -0.377, -0.377, -0.377, -0.362, -0.377, -0.362, -0.214, -0.360, -0.299, -0.299, -0.218, -0.106, -0.131, -0.350, -0.377, -0.377, -0.362, -0.131, -0.341, -0.250, -0.267, -0.365, -0.155, -0.069, -0.095, -0.343, -0.376, -0.376, -0.360, 0.327, 0.268, 0.293, 0.304, 0.321, 0.332, 0.339, 0.322, 0.296, 0.278, 0.255, 0.269, 0.298, 0.293 };
        double[] vz = { 0.042, 0.042, 0.042, 0.042, 0.077, 0.042, 0.077, 0.000, 0.000, 0.000, 0.042, -0.042, -0.042, -0.042, -0.077, -0.077, -0.042, -0.042, -0.042, 0.000, -0.077, -0.077, -0.077, -0.077, -0.077, -0.077, -0.077, -0.169, -0.116, -0.077, -0.077, -0.077, -0.077, 0.000, -0.077, 0.077, 0.077, 0.000, -0.077, 0.077, -0.095, -0.095, -0.107, -0.095, -0.107, 0.000, -0.077, -0.077, -0.095, -0.107, -0.095, -0.077, 0.000, 0.077, 0.000, 0.077, 0.095, 0.095, 0.107, 0.107, 0.095, 0.107, 0.077, 0.077, 0.077, 0.077, 0.095, 0.095, 0.077, 0.077, 0.077, 0.077, 0.077, 0.077, 0.169, 0.116, 0.077, 0.000, 0.126, -0.126, 0.000, 0.000, 0.000, 0.108, 0.108, 0.000, 0.077, 0.132, 0.132, 0.132, 0.132, 0.151, 0.104, 0.132, 0.132, 0.132, 0.132, 0.132, 0.132, 0.132, 0.169, 0.169, 0.169, 0.108, 0.134, 0.151, 0.133, 0.133, 0.134, 0.133, 0.091, 0.021, 0.133, 0.133, 0.133, 0.133, 0.133, 0.133, 0.133, 0.000, 0.000, 0.021, -0.108, -0.091, 0.000, 0.021, -0.169, -0.021, -0.021, 0.000, 0.021, -0.021, 0.000, 0.021, -0.021, 0.000, -0.134, -0.021, -0.134, -0.169, -0.151, -0.133, -0.133, -0.133, -0.169, -0.104, -0.151, -0.132, -0.133, -0.133, -0.133, -0.133, -0.133, -0.133, -0.133, -0.108, -0.132, -0.132, -0.132, -0.132, -0.132, -0.132, -0.132, -0.132, -0.132, -0.132, -0.077, -0.108, 0.000, -0.042, 0.042, 0.000, -0.042, 0.042, 0.000, -0.042, 0.042, 0.000, -0.072, -0.132, 0.000, -0.072, -0.132, -0.072, -0.132, -0.072, -0.132, -0.072, -0.132, -0.072, -0.132, -0.151, 0.072, 0.132, 0.072, 0.132, 0.072, 0.132, 0.072, 0.132, 0.072, 0.132, 0.072, 0.132, 0.151, 0.000, 0.104, -0.104, 0.000, 0.169, -0.169, 0.000, 0.151, -0.151, 0.069, -0.069, 0.133, -0.133, 0.069, -0.069, 0.133, 0.069, 0.133, -0.133, -0.069, -0.133, 0.021, 0.021, 0.021, 0.021, 0.021, 0.021, 0.021, 0.021, 0.091, 0.021, 0.000, 0.021, 0.000, -0.021, -0.021, 0.021, 0.000, 0.021, 0.000, 0.021, -0.021, -0.021, -0.021, 0.000, 0.021, -0.021, 0.000, 0.134, -0.134, 0.134, 0.000, 0.134, 0.000, 0.133, -0.134, -0.134, -0.133, 0.069, -0.069, 0.133, -0.133, 0.069, -0.069, 0.133, -0.133, 0.069, -0.069, 0.133, -0.133, 0.069, 0.133, 0.069, -0.069, -0.133, -0.069, 0.069, 0.133, 0.069, 0.133, 0.069, 0.133, 0.069, 0.133, 0.069, 0.133, 0.069, 0.133, 0.132, 0.072, 0.132, 0.072, 0.132, 0.072, 0.132, 0.072, 0.132, 0.072, 0.132, 0.072, 0.072, 0.132, 0.072, 0.132, 0.072, 0.072, 0.072, 0.072, 0.072, 0.072, 0.072, 0.072, 0.072, 0.072, 0.072, 0.069, 0.069, 0.069, 0.069, 0.069, 0.069, 0.069, 0.069, 0.069, 0.069, 0.000, 0.000, 0.095, 0.077, 0.077, 0.095, 0.095, 0.077, 0.077, 0.095, 0.107, 0.107, 0.107, 0.095, 0.077, 0.077, -0.021, -0.021, -0.021, -0.021, -0.021, -0.021, -0.021, -0.021, -0.091, -0.069, -0.133, -0.133, -0.069, -0.069, -0.133, -0.133, -0.069, -0.069, -0.133, -0.133, -0.069, -0.072, -0.132, -0.132, -0.072, -0.132, -0.072, -0.132, -0.072, -0.132, -0.072, -0.132, -0.072, -0.072, -0.132, -0.132, -0.072, -0.072, -0.072, -0.072, -0.072, -0.072, -0.072, -0.072, -0.072, -0.072, -0.072, -0.072, -0.069, -0.069, -0.069, -0.069, -0.069, -0.069, 0.000, 0.000, -0.069, -0.069, -0.069, -0.069, -0.077, -0.095, -0.077, -0.095, -0.095, -0.077, -0.077, -0.095, -0.107, -0.107, -0.107, -0.095, -0.077, -0.077 };
        int[] tris = new int[] { 0, 1, 2, 1, 0, 3, 1, 3, 4, 4, 5, 1, 4, 6, 5, 5, 7, 1, 6, 8, 5, 7, 5, 8, 9, 1, 7, 1, 9, 10, 11, 9, 7, 9, 11, 12, 13, 7, 8, 7, 13, 11, 8, 14, 13, 15, 11, 13, 15, 13, 14, 11, 15, 16, 17, 11, 16, 11, 17, 18, 8, 6, 19, 14, 8, 19, 14, 20, 15, 15, 20, 21, 15, 21, 22, 23, 15, 22, 23, 24, 15, 20, 14, 25, 15, 24, 26, 24, 27, 26, 27, 24, 28, 27, 29, 26, 19, 30, 14, 14, 31, 25, 31, 14, 32, 30, 19, 33, 33, 34, 30, 19, 35, 33, 35, 19, 6, 36, 33, 35, 34, 33, 37, 33, 36, 37, 37, 38, 34, 39, 37, 36, 40, 25, 31, 25, 40, 41, 40, 42, 41, 43, 42, 40, 31, 43, 40, 42, 43, 44, 38, 37, 45, 37, 39, 45, 43, 31, 46, 38, 43, 46, 32, 46, 31, 46, 32, 47, 38, 46, 47, 48, 44, 43, 43, 38, 48, 44, 48, 49, 50, 49, 48, 48, 51, 50, 51, 48, 38, 45, 51, 38, 51, 45, 52, 52, 24, 51, 53, 45, 39, 45, 53, 52, 24, 52, 54, 54, 28, 24, 55, 52, 53, 52, 55, 54, 56, 53, 39, 53, 56, 57, 57, 56, 58, 56, 59, 58, 59, 56, 60, 39, 60, 56, 60, 61, 59, 60, 39, 62, 62, 39, 63, 64, 62, 63, 62, 64, 65, 65, 60, 62, 6, 65, 64, 61, 60, 66, 60, 65, 66, 66, 67, 61, 66, 68, 67, 68, 66, 65, 65, 6, 68, 6, 69, 68, 69, 6, 4, 4, 70, 69, 4, 71, 70, 72, 71, 4, 72, 4, 55, 55, 4, 73, 74, 55, 73, 55, 74, 75, 74, 73, 76, 75, 54, 55, 54, 75, 77, 28, 54, 77, 74, 78, 75, 78, 77, 75, 77, 79, 28, 79, 27, 28, 77, 78, 80, 79, 77, 80, 73, 81, 76, 82, 76, 81, 74, 76, 83, 76, 82, 84, 81, 73, 85, 86, 85, 73, 74, 83, 87, 87, 83, 88, 87, 88, 89, 87, 89, 90, 74, 87, 91, 92, 74, 91, 87, 90, 93, 87, 93, 94, 94, 93, 95, 93, 90, 96, 93, 96, 97, 93, 97, 98, 97, 96, 99, 74, 92, 100, 78, 74, 100, 101, 100, 92, 102, 78, 100, 100, 101, 102, 78, 102, 103, 103, 80, 78, 104, 102, 101, 104, 101, 105, 104, 105, 106, 104, 106, 107, 102, 104, 108, 107, 106, 109, 110, 102, 108, 102, 110, 103, 110, 108, 111, 107, 109, 112, 107, 112, 113, 112, 109, 114, 112, 114, 115, 112, 115, 116, 112, 116, 117, 116, 115, 118, 110, 119, 103, 80, 103, 119, 119, 110, 120, 121, 120, 110, 122, 80, 119, 80, 122, 79, 119, 123, 122, 123, 119, 120, 120, 121, 124, 125, 124, 121, 126, 79, 122, 123, 126, 122, 120, 127, 123, 127, 120, 124, 124, 128, 127, 124, 125, 129, 128, 124, 129, 130, 129, 125, 129, 131, 128, 129, 130, 132, 131, 129, 132, 133, 132, 130, 132, 134, 131, 132, 133, 135, 134, 132, 135, 126, 123, 136, 123, 137, 136, 138, 126, 136, 126, 138, 139, 138, 140, 139, 138, 141, 140, 138, 142, 141, 141, 142, 143, 139, 144, 126, 79, 126, 144, 144, 139, 145, 27, 79, 144, 145, 27, 144, 27, 145, 146, 27, 146, 147, 143, 142, 148, 148, 142, 149, 143, 148, 150, 150, 148, 151, 151, 148, 152, 151, 152, 153, 152, 148, 154, 27, 147, 155, 27, 155, 29, 155, 147, 156, 147, 157, 156, 147, 158, 157, 147, 159, 158, 147, 160, 159, 159, 160, 161, 158, 159, 162, 162, 159, 163, 162, 163, 164, 163, 159, 165, 81, 26, 29, 29, 82, 81, 26, 81, 85, 85, 166, 26, 82, 29, 167, 166, 85, 168, 85, 86, 168, 168, 169, 166, 170, 168, 86, 169, 168, 171, 168, 170, 171, 171, 172, 169, 173, 171, 170, 172, 171, 174, 171, 173, 174, 174, 175, 172, 176, 174, 173, 175, 174, 177, 174, 176, 177, 167, 178, 82, 178, 167, 179, 178, 180, 82, 180, 178, 181, 182, 180, 181, 179, 183, 178, 183, 179, 184, 184, 185, 183, 185, 184, 186, 186, 187, 185, 187, 186, 188, 188, 189, 187, 189, 188, 190, 180, 182, 191, 180, 192, 82, 192, 84, 82, 84, 192, 193, 194, 193, 192, 193, 194, 195, 196, 195, 194, 195, 196, 197, 198, 197, 196, 197, 198, 199, 200, 199, 198, 199, 200, 201, 192, 180, 202, 180, 203, 202, 203, 180, 204, 205, 204, 180, 191, 205, 180, 204, 205, 206, 205, 191, 207, 208, 206, 205, 207, 208, 205, 206, 208, 209, 208, 207, 210, 211, 209, 208, 210, 211, 208, 209, 211, 212, 211, 210, 213, 214, 212, 211, 213, 215, 211, 212, 214, 216, 215, 213, 217, 218, 216, 214, 217, 219, 215, 216, 218, 220, 221, 220, 218, 220, 221, 222, 219, 217, 223, 223, 224, 219, 224, 223, 225, 226, 227, 228, 226, 229, 227, 227, 229, 230, 231, 229, 226, 232, 229, 231, 232, 233, 229, 234, 233, 232, 235, 236, 237, 236, 235, 238, 239, 236, 238, 236, 239, 240, 241, 242, 243, 242, 241, 244, 245, 244, 241, 246, 242, 244, 242, 246, 247, 244, 248, 246, 244, 245, 249, 248, 244, 249, 250, 249, 245, 249, 251, 248, 249, 250, 252, 251, 249, 252, 252, 250, 253, 252, 254, 251, 255, 256, 257, 256, 255, 258, 259, 258, 255, 260, 256, 258, 256, 260, 261, 258, 262, 260, 258, 259, 263, 262, 258, 264, 265, 263, 259, 264, 266, 262, 263, 265, 267, 266, 264, 268, 269, 267, 265, 268, 270, 266, 267, 269, 271, 270, 268, 272, 273, 271, 269, 272, 274, 270, 271, 273, 275, 276, 275, 273, 275, 276, 277, 274, 272, 278, 278, 279, 274, 279, 278, 280, 281, 282, 283, 282, 281, 284, 285, 286, 287, 286, 285, 288, 289, 290, 291, 290, 289, 292, 293, 294, 295, 294, 293, 296, 297, 296, 293, 296, 297, 298, 299, 298, 297, 298, 299, 300, 301, 300, 299, 300, 301, 302, 303, 302, 301, 302, 303, 304, 305, 306, 307, 306, 305, 308, 309, 310, 311, 309, 312, 310, 310, 312, 313, 314, 312, 309, 314, 315, 312, 312, 315, 316, 317, 315, 314, 318, 315, 317, 319, 315, 318, 320, 321, 322, 320, 323, 321, 321, 323, 324, 325, 323, 320, 325, 326, 323, 327, 326, 325, 327, 328, 326, 327, 325, 329, 329, 330, 327, 330, 329, 331, 332, 333, 334, 333, 332, 335, 336, 333, 335, 333, 336, 337, 336, 338, 337, 338, 336, 339, 339, 336, 340, 336, 341, 340, 341, 336, 335, 335, 342, 341, 342, 335, 332, 332, 343, 342, 332, 344, 343, 344, 332, 345, 346, 347, 348, 346, 349, 347, 347, 349, 350, 346, 351, 349, 346, 352, 351, 353, 352, 346, 354, 352, 353, 355, 356, 357, 356, 355, 358, 359, 360, 361, 360, 359, 362, 363, 364, 365, 364, 363, 366, 367, 368, 369, 368, 367, 370, 370, 371, 368, 371, 370, 372, 372, 373, 371, 373, 372, 374, 374, 375, 373, 375, 374, 376, 376, 377, 375, 377, 376, 378, 379, 380, 381, 380, 379, 382, 383, 384, 385, 383, 386, 384, 383, 387, 386, 383, 388, 387, 389, 388, 383, 384, 386, 390, 384, 390, 391, 384, 391, 392, 391, 390, 393, 394, 395, 396, 394, 397, 395, 395, 397, 398, 394, 399, 397, 400, 399, 394, 399, 400, 401, 398, 397, 402, 398, 402, 403, 398, 403, 404, 403, 402, 405, 406, 407, 408, 407, 406, 409, 406, 410, 409, 410, 406, 411, 412, 410, 411, 410, 412, 413, 413, 414, 410, 415, 410, 414, 410, 415, 409, 416, 409, 415, 409, 416, 407, 407, 416, 417, 418, 407, 417, 407, 418, 419 };

        Vector3[] verts = new Vector3[vx.Length];
        for (int n = 0; n < verts.Length; ++n)
            verts[n] = new Vector3((float)vz[n], (float)vy[n], - (float)vx[n]);

        go.AddComponent<GoodBoy>();
        MeshRenderer mr = go.AddComponent<MeshRenderer>();
        MeshFilter mf = go.AddComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        mesh.vertices = verts;
        mesh.triangles = tris;
        mesh.RecalculateNormals();
        mf.mesh = mesh;
        mr.material = new Material(Shader.Find("Standard"));
        go.AddComponent<MeshCollider>();
        
        // position at scene view focus point
        Vector3 scenePos = SceneView.lastActiveSceneView.pivot;
        go.transform.position = scenePos;

        // Register the creation in the undo system
        Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
        Selection.activeObject = go;
        Debug.Log("Woof");
    }


    void Update(){
        // they're all good dogs
        good = true;
    }*/
    
}