using System;
public class vars {
    //  Here you can change an array of x and y
        public static double[] arr_x = {7.6, 7.2, 6.8, 13.4, 20.1, 12.3, 4.5, 4.6, 4.7, 12.5, 20.2, 14.9, 9.9, 12.0};  //  Init of Xi 
        public static double[] arr_y = {27.2, 20.3, 13.4, 16.5, 19.7, 20.8, 21.9, 20.2, 18.7, 20.9, 23.0, 21.1, 19.0, 23.9};  //  Init of Yi
        public static int n = arr_x.Length;  //  Length of arr_x = 14
        public static int m = 2;  //  Number of tables(arrays)
        //  const func variables
        public static double sum_x = Regression.Sum_x(arr_x);
        public static double sum_y = Regression.Sum_y(arr_y);
        public static double pow_sum_x = Regression.Pow_sum_x(arr_x);
        public static double pow_sum_y = Regression.Pow_sum_y(arr_y);
        public static double sum_xy = Regression.Sum_xy(arr_x, arr_y);
        //*********************************************************************//
        public static double regres_a1 = Regression.Regression_coef_A1();
        public static double regres_a0 = Regression.Regression_coef_A0();
        public static double regres_ta1 = Regression.Regression_coef_TA1();
        public static double regres_ta0 = Regression.Regression_coef_TA0();
        //*********************************************************************//
        public static double averageX = Regression.Average_X();
        public static double averageY = Regression.Average_Y();
        //*********************************************************************//
        public static double general_variation_x = Regression.General_variation_X(arr_x);
        public static double general_variation_y = Regression.General_variation_Y(arr_y);
        public static double explained_variation = Regression.Explained_variation(arr_x);
        //*********************************************************************//
        public static double MultipleCoef = Regression.Multiple_coeff();
        public static double aveSqrtDevRes = Regression.Average_sqrt_dev_res();
        public static double aveSqrtDevFac_x = Regression.Average_sqrt_dev_fac_x();
        public static double aveSqrtDevFac_y = Regression.Average_sqrt_dev_fac_y();
}
public class Regression {
    static void Main() {
        // Coefficient_Determination();
        // Nature_rel();
        // Connection_close();
        // StudentQuantiles();
        // FisherCriteria();
        //  To see values of calculations uncomment below function (you can also comment everything above(in main) for clear readings)
        DebugValues();
  }
  //  Fisher's F-criteria
  static void FisherCriteria() {
    double fCrit = 0.0;
    double F_table = 0.0;
    int v1 = vars.m - 1;
    int v2 = vars.n - vars.m;
    double divideUp1 = Math.Pow(vars.aveSqrtDevFac_y, 2);
    double divideUp2 = vars.n - vars.aveSqrtDevFac_x;
    double divideDown1 = Math.Pow(vars.aveSqrtDevRes, 2);
    double divideDown2 = vars.aveSqrtDevFac_x - 1;
    fCrit = (divideUp1/divideDown1) * (divideUp2 / divideDown2);
    //Matrix of values
    double[,] matrix = {
        {161.4, 199.5, 215.7, 224.6, 230.2, 234.0},
        {18.51, 19.00, 19.6, 19.25, 19.30, 19.33},
        {10.13, 9.55, 9.28, 9.12, 9.01, 8.94},
        {7.71, 6.94, 6.59, 6.39, 6.26, 6.16},
        {6.61, 5.79, 5.41, 5.19, 5.05, 4.95},
        {5.99, 5.14, 4.76, 4.53, 4.39, 4.28},
        {5.59, 4.74, 4.35, 4.12, 3.97, 3.87},
        {5.32, 4.46, 4.07, 3.84, 3.69, 3.58},
        {5.12, 4.26, 3.86, 3.63, 3.48, 3.37},
        {4.96, 4.10, 3.71, 3.48, 3.33, 3.22},
        {4.84, 3.98, 3.59, 3.36, 3.20, 3.09},
        {4.75, 3.88, 3.49, 3.26, 3.11, 3.00},
        {4.67, 3.80, 3.41, 3.18, 3.02, 2.92},
        {4.60, 3.74, 3.34, 3.11, 2.96, 2.85}
    };
    Console.WriteLine("Fisher's F-criteria");
    Console.WriteLine($"v1 = {v1}, v2 = {v2}");
    for (int i = 0; i <= v2-1; i++) {
        for (int j = 0; j <= v1-1; j++) {
            F_table = matrix[i, j];
        }
    }
    Console.WriteLine($"F table is {F_table}");
    Console.WriteLine("/********************************************************/");
  }
  //  Student's distribution quantiles
  static void StudentQuantiles() {
    double v = vars.n - vars.m - 1;
    double buff = 0;
    Console.WriteLine("Student quants table");
    Console.WriteLine("Number of degrees freedom of variation(Rounded to nearest number - V): " + v);
    Console.WriteLine("Levels of significance(alpha) is 0.05");
    switch (v)
    {
        case 1:
        buff = 12.71;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 2:
        buff = 4.30;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 3:
        buff = 3.18;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 4:
        buff = 2.78;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 5:
        buff = 2.57;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 6:
        buff = 2.45;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 7:
        buff = 2.37;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 8:
        buff = 2.31;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 9:
        buff = 2.26;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 10:
        buff = 2.23;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 15:
        buff = 2.13;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 20:
        buff = 2.09;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 30:
        buff = 2.04;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        case 40:
        buff = 2.02;
        Console.WriteLine($"Quantiles is {buff}");
        break;
        default:
        Console.WriteLine("Quantiless null");
        break;
    }
    if (vars.regres_ta0 > buff && vars.regres_ta1 > buff) {
        Console.WriteLine("Parameter is significant");
    } else {
        Console.WriteLine("Parameter is insignificant");
    }
    Console.WriteLine("/********************************************************/");
  }
  //  Percentage of variation
  static void Coefficient_Determination() {
    double coeff_deter = Math.Round(vars.explained_variation / vars.general_variation_y, 3);
    Console.WriteLine("Percentage of variation is " + coeff_deter.ToString("0.00%"));
    Console.WriteLine("/********************************************************/");
  }
  // Estimation of the correlation coefficient r by the degree of connection closeness
  static void Connection_close() {
    Console.WriteLine("Estimation of the correlation coefficient r by the degree of connection closeness");
    if (vars.MultipleCoef < Math.Abs(0.3)) {
        Console.Write("Nature of the relationship: ");
        Console.WriteLine("Almost absent");
    } else if (Math.Abs(0.3) < vars.MultipleCoef && vars.MultipleCoef < Math.Abs(0.5)) {
        Console.Write("Nature of the relationship: ");
        Console.WriteLine("Weak");      
    } else if (Math.Abs(0.5) < vars.MultipleCoef && vars.MultipleCoef < Math.Abs(0.7)) {
        Console.Write("Nature of the relationship: ");
        Console.WriteLine("Moderate");
    } else if (Math.Abs(0.7) < vars.MultipleCoef && vars.MultipleCoef < Math.Abs(1.0)) {
        Console.Write("Nature of the relationship: ");
        Console.WriteLine("Strong");
    }
    Console.WriteLine("/********************************************************/");
  }
  //  Estimation of the linear correlation coefficient r by the nature of the relationship
  static void Nature_rel() {
    Console.WriteLine("Estimation of the linear correlation coefficient r by the nature of the relationship");
    Console.WriteLine("Multiple coefficient is " + vars.MultipleCoef);
    if (vars.MultipleCoef == 0) {
        Console.Write("Nature of the relationship: ");
        Console.WriteLine("Relationship is absent");
        Console.Write("Interpretation: ");
        Console.WriteLine("NULL");
    } else if (vars.MultipleCoef == 1) {
        Console.Write("Nature of the relationship: ");
        Console.WriteLine("Functional, linear");
        Console.Write("Interpretation: ");
        Console.WriteLine("Each value of the factorial sign strictly corresponds one function value, as X increases, Y increases");
    } else if (vars.MultipleCoef == -1) {
        Console.Write("Nature of the relationship: ");
        Console.WriteLine("Functional, reverse");
        Console.Write("Interpretation: ");
        Console.WriteLine("Each value of the factorial sign strictly corresponds one function value, as X increases, Y decreases and vice versa");
    } else if (0 < vars.MultipleCoef && vars.MultipleCoef < 1) {
        Console.Write("Nature of the relationship: ");
        Console.WriteLine("Probalistic, linear");
        Console.Write("Interpretation: ");
        Console.WriteLine("As X increases, Y increases");
    } else if (-1 < vars.MultipleCoef && vars.MultipleCoef < 1) {
        Console.Write("Nature of the relationship: ");
        Console.WriteLine("Probalistic, reverse");
        Console.Write("Interpretation: ");
        Console.WriteLine("As X increases, Y decreases and vice versa");
    }
    Console.WriteLine("/********************************************************/");
  }
  //  Multiple coefficient
  public static double Multiple_coeff() {
    // Function variables
    double coef = 0.0;
    double DivideUp = vars.n * vars.sum_xy - vars.sum_x * vars.sum_y;
    double DivideDown = Math.Sqrt(vars.n * vars.pow_sum_x - Math.Pow(vars.sum_x, 2)) * (vars.n * vars.pow_sum_y - Math.Pow(vars.sum_y, 2));
    //**************************************
    coef = DivideUp / DivideDown;
    return Math.Round(coef, 3);
  }
  //  General variation y
  public static double General_variation_Y(double[] y) {
    // Function variables
    double general_variation = 0.0;
    for (int i = 1; i < y.Length; i++) {
        general_variation += Math.Pow((y[i] - vars.averageY), 2);
    }
    return Math.Round(general_variation, 3);
  }
    //  General variation x
  public static double General_variation_X(double[] x) {
    // Function variables
    double general_variation = 0.0;
    for (int i = 1; i < x.Length; i++) {
        general_variation += Math.Pow((x[i] - vars.averageX), 2);
    }
    return Math.Round(general_variation, 3);
  }
   //  Explained variation
  public static double Explained_variation(double[] x) {
    // Function variables
    double explainVar = 0.0;
    for (int i = 1; i < x.Length; i++) {
        explainVar += Math.Pow((vars.regres_a0 + 
        vars.regres_a1 * x[i]) - vars.averageY, 2);
    }
    return Math.Round(explainVar, 3);
  }
  //  Average square deviation of result nature y
  public static double Average_sqrt_dev_res() {
    //  Function variables
    double aveSqrtDev = 0.0;
    aveSqrtDev = Math.Sqrt(vars.explained_variation/vars.n);
    return Math.Round(aveSqrtDev, 3);
  }
  //  Average square deviation of factor nature x
  public static double Average_sqrt_dev_fac_x() {
    //  Function variables
    double aveSqrtDev = 0.0;
    aveSqrtDev = Math.Sqrt(vars.general_variation_x/vars.n);
    return Math.Round(aveSqrtDev, 3);
  }
    //  Average square deviation of factor nature y
  public static double Average_sqrt_dev_fac_y() {
    //  Function variables
    double aveSqrtDev = 0.0;
    aveSqrtDev = Math.Sqrt(vars.general_variation_y/vars.n);
    return Math.Round(aveSqrtDev, 3);
  }
  //  Average of Yi
  public static double Average_Y() {
    double average = 0.0;
    average = vars.sum_y / vars.n;
    return Math.Round(average, 3);
  }
  //  Average of Xi
  public static double Average_X() {
    double average = 0.0;
    average = vars.sum_x / vars.n;
    return Math.Round(average, 3);
  }
  //  Regression_coef_A1
  public static double Regression_coef_A1() {
    // Function variables
      double a1 = 0.0;
      //**************************************
      double DivideUp = vars.n * vars.sum_xy - vars.sum_y * vars.sum_x;
      double DivideDown = vars.n * vars.pow_sum_x - Math.Pow(vars.sum_x, 2);
      a1 = DivideUp / DivideDown;
      return Math.Round(a1, 3);
  }
    //  Regression_coef_TA1
  public static double Regression_coef_TA1() {
    // Function variables
      double a1 = 0.0;
      //**************************************
      double DivideUp = Math.Sqrt(vars.n - 2.0);
      double DivideDown = vars.aveSqrtDevRes  ;
      a1 = Math.Abs(vars.regres_a1) * (DivideUp / DivideDown) * vars.aveSqrtDevFac_x;
      return Math.Round(a1, 3);
  }
  //  Regression_coef_A0
  public static double Regression_coef_A0() {
    // Function variables
    double a0 = 0.0;
    double multipleLeft = 1.0/vars.n;
    double multipleRight = vars.sum_y - vars.regres_a1 * vars.sum_x;
    //**************************************
    a0 = multipleLeft * multipleRight;
    return Math.Round(a0, 3);
  }
      //  Regression_coef_TA0
  public static double Regression_coef_TA0() {
    // Function variables
      double a0 = 0.0;
      //**************************************
      double DivideUp = Math.Sqrt(vars.n - 2.0);
      double DivideDown = vars.aveSqrtDevRes;
      a0 = Math.Abs(vars.regres_a0) * (DivideUp / DivideDown);
      return Math.Round(a0, 3);
  }
  //  Sum of all Xi
  public static double Sum_x(double[] x) {
      double sum = 0.0;
      for (int i = 0; i < x.Length; i++) {
          sum += x[i];
      }
      return Math.Round(sum, 3);
  }
  // Sum of all Xi^2
  public static double Pow_sum_x(double[] x) {
      double sum = 0.0;
      for (int i = 0; i < x.Length; i++) {
          sum += Math.Pow(x[i], 2);
      }
      return Math.Round(sum, 3);
  }
  // Sum of all Yi
  public static double Sum_y(double[] y) {
      double sum = 0.0;
      for (int i = 0; i < y.Length; i++) {
          sum += y[i];
      }
      return Math.Round(sum, 3);
  }
  // Sum of all Yi^2
  public static double Pow_sum_y(double[] y) {
      double sum = 0.0;
      for (int i = 0; i < y.Length; i++) {
          sum += Math.Pow(y[i], 2);
      }
      return Math.Round(sum, 3);
  }
  // Sum of all Xi * Yi
  public static double Sum_xy(double[] x, double[] y) {
      double sum = 0.0;
      for (int i = 0; i < x.Length; i++) {
          sum += x[i] * y[i];
      }
      return Math.Round(sum, 3);
  }
  static void DebugValues() {
      Console.WriteLine("Sum of x: " + vars.sum_x);
      Console.WriteLine("Sum of y: " + vars.sum_y);
      Console.WriteLine("Sum of x^2: " + vars.pow_sum_x);
      Console.WriteLine("Sum of y^2: " + vars.pow_sum_y);
      Console.WriteLine("Sum of xy: " + vars.sum_xy);
      Console.WriteLine("a0: " + vars.regres_a0);
      Console.WriteLine("a1: " + vars.regres_a1);
      Console.WriteLine("ta0: " + vars.regres_ta0);
      Console.WriteLine("ta1: " + vars.regres_ta1);
      Console.WriteLine("Average of x: " + vars.averageX);
      Console.WriteLine("Average of y: " + vars.averageY);
      Console.WriteLine("Explained variation: " + vars.explained_variation);
      Console.WriteLine("General variation of x: " + vars.general_variation_x);
      Console.WriteLine("General variation of y: " + vars.general_variation_y);
      Console.WriteLine("Coefficient of determination: " + Math.Round(vars.explained_variation / vars.general_variation_y, 3));
      Console.WriteLine("Multiple coefficient: " + vars.MultipleCoef);
      Console.WriteLine("Average square deviation of result nature of y: " + vars.aveSqrtDevRes);
      Console.WriteLine("Average square deviation of factor nature of x: " + vars.aveSqrtDevFac_x);
      Console.WriteLine("Average square deviation of factor nature of y: " + vars.aveSqrtDevFac_y);
  }
}
