    public int[] KWeakestRows(int[][] mat, int k)
    {
        var ar = new int[mat.Length];
        var bc = new int[k];

        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                ar[i] += mat[i][j];
            }
        }

        Array.Sort(ar);
        Array.Copy(ar, bc, k);
        return bc;
    }