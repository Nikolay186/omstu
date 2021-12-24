def paint():
    xpts = np.array([0, 160])
    ypts = np.array([0, 50])

    mpl.plot(xpts, ypts)
    mpl.show()

if __name__ == "__main__":
    import numpy as np
    import matplotlib.pyplot as mpl
    paint()