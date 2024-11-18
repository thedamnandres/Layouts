# Especificaciones de la Aplicación

## Requerimientos Generales
- Generar una aplicación que tenga **4 pantallas**.
- Cada pantalla debe tener un layout diferente con las siguientes características.

---

### **1. Pantalla con GridLayout**
- **Diseño**:
  - Cuatro cuadrados de colores diferentes, cada uno ocupando un cuarto de la pantalla.
  - El último cuadrante contiene un botón.
- **Acción**:
  - El botón redirige a la pantalla con el `StackLayout`.

---

### **2. Pantalla con StackLayout**
- **Diseño**:
  - Un `StackLayout` vertical que contenga tres etiquetas de texto.
  - Cada etiqueta debe tener un tamaño de fuente diferente.
- **Acción**:
  - Incluir un botón que redirija a la pantalla con el `FlexLayout`.

---

### **3. Pantalla con FlexLayout**
- **Diseño**:
  - Un `FlexLayout` que muestre una lista vertical de elementos.
  - Cada elemento debe tener:
    - Una imagen a la izquierda.
    - Un texto (su nombre) a la derecha.
- **Acción**:
  - Al hacer clic en cualquier imagen, se redirige a la pantalla con el `AbsoluteLayout`.

---

### **4. Pantalla con AbsoluteLayout**
- **Diseño**:
  - Un `AbsoluteLayout` que contenga un botón en la esquina inferior derecha de la pantalla.
  - El botón debe mantenerse en esa posición incluso al hacer scroll.
- **Acción**:
  - El botón redirige de nuevo a la pantalla con el `GridLayout`.
