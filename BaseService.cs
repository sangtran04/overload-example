using System;
using System.Data;

/// <summary>
/// Dữ liệu trả về của service
/// </summary>
public class ServiceResult
{
    /// <summary>
    /// Thành công hay Thất bại
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// Mã lỗi trả về (nếu có)
    /// </summary>
    public string? ErrorCode { get; set; }

    /// <summary>
    /// Dữ liệu trả về kèm (nếu có)
    /// </summary>
    public string? Data { get; set; }

    /// <summary>
    /// Message trả về kèm (nếu có)
    /// </summary>
    public string? Message { get; set; }
}

/// <summary>
/// Base service
/// </summary>
public class BaseService<T>
{
    /*
     * Overload: 
     * - Trong cùng một class
     * - Cùng tên hàm: InsertAsync
     * - KHÁC tham số đầu vào
     */

    /// <summary>
    /// Thêm mới 1 đối tượng
    /// </summary>
    /// <param name="entity">Đối tượng muốn thêm mới</param>
    /// <returns>
    /// Nếu thêm mới thành công thì đối tượng ServiceResult trả về có IsSuccess = true. 
    /// Nếu thêm mới thất bại thì đối tượng ServiceResult trả về có IsSuccess = false. 
    /// </returns>
    public ServiceResult InsertAsync(
        T entity)
    {
        // Do something
        return new ServiceResult { IsSuccess = true };
    }

    /// <summary>
    /// Thêm mới 1 đối tượng
    /// </summary>
    /// <param name="dbConnection">Thông tin kết nối đến database</param>
    /// <param name="entity">Đối tượng muốn thêm mới</param>
    /// <returns>
    /// Nếu thêm mới thành công thì đối tượng ServiceResult trả về có IsSuccess = true. 
    /// Nếu thêm mới thất bại thì đối tượng ServiceResult trả về có IsSuccess = false. 
    /// </returns>
    public ServiceResult InsertAsync(
        IDbConnection dbConnection,
        T entity)
    {
        // Do something with dbConnection
        return new ServiceResult { IsSuccess = true };
    }
}
