# EVALUACION - BankManagementSystem

## Informacion general
- Estudiante(s): Manuela Taborda Muñoz
- Rama evaluada: master
- Commit evaluado: af7d550
- Fecha: 2026-04-13
- Novedades de ramas: `develop` y `main` no existen en remoto/local; se continua con la rama disponible (`master`) segun el proceso.
- Alcance aplicado: solo capa de dominio (`BankManagementSystem.Domain/**`).

## Tabla de calificacion

| Criterio | Peso | Puntaje (1-5) | Justificacion breve |
|---|---:|---:|---|
| 1. Modelado de dominio | 20% | 3.0 | Existen entidades base (`User`, `BankAccount`, `Loan`, `Transfer`), pero faltan elementos importantes del contexto esperado (cliente natural/empresa, producto bancario, bitacora). |
| 2. Modelado de puertos | 20% | 2.0 | Hay interfaces de dominio, pero cobertura parcial y con contratos todavia genericos; faltan puertos por agregado para casos del enunciado. |
| 3. Servicios de dominio | 20% | 2.0 | Solo se observan servicios de dominio puntuales (`BankDomainService`, `TransferDomainService`) con cobertura limitada frente al conjunto de casos de uso requeridos. |
| 4. Enums y estados | 10% | 3.0 | Se usan enums en prestamos/transferencias/rol, pero el modelado de estados no cubre todos los catalogos y transiciones esperadas del contexto. |
| 5. Reglas de negocio criticas | 10% | 2.0 | Se valida monto y aprobacion en transferencias, pero faltan reglas clave de cuentas, prestamos y expiracion operativa de pendientes segun el enunciado. |
| 6. Bitacora y trazabilidad | 5% | 1.0 | No se evidencia bitacora de dominio para auditoria de operaciones criticas. |
| 7. Estructura interna de dominio | 10% | 3.0 | La estructura por carpetas existe y es entendible, aunque con alcance funcional incompleto para el dominio bancario objetivo. |
| 8. Calidad tecnica base en domain | 5% | 4.0 | Codigo legible y consistente en general; se recomienda fortalecer excepciones de negocio especificas en lugar de `Exception` generica. |

## Calculo
- Nota base ponderada: **2.45 / 5.0**
- Penalizaciones aplicadas: **ninguna**
- Bonus aplicados: **ninguno**
- Nota final: **2.45 / 5.0**

## Hallazgos
- Fortalezas:
  - Separacion inicial de capa de dominio con entidades, enums, interfaces y servicios.
  - Reglas basicas de transferencia ya implementadas (monto y aprobacion por umbral).
- Brechas principales:
  - Falta cobertura de agregados y puertos completos para el contexto bancario definido en la evaluacion.
  - Servicios de dominio insuficientes para cubrir ciclo completo de cuentas, prestamos y transferencias.
  - Ausencia de bitacora de auditoria en dominio.

## Recomendaciones
1. Ampliar el modelo de dominio con cliente (natural/empresa), producto bancario y bitacora de operaciones.
2. Diseñar puertos por agregado con contratos semanticos (consultas/comandos) alineados a reglas de negocio.
3. Implementar servicios de dominio por caso de uso (apertura/bloqueo/cancelacion de cuentas, ciclo de prestamos, ejecucion/expiracion de transferencias).
4. Sustituir excepciones genericas por excepciones de negocio especificas (`BusinessException`, `NotFoundException`).

## Nota final
**2.45 / 5.0**
