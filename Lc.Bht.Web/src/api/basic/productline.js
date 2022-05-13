import request from '@/utils/request'

export function queryProductline(data) {
  return request({
    url: 'api/productline/query',
    method: 'post',
    data
  })
}

export function getProductline(id) {
  return request({
    url: 'api/productline/get?id=' + id,
    method: 'get'
  })
}

export function getAllProductline(enable) {
  return request({
    url: 'api/productline/getAll' + (enable === undefined ? '' : ('?enable=' + enable)),
    method: 'get'
  })
}

export function createProductline(data) {
  return request({
    url: 'api/productline/create',
    method: 'post',
    data
  })
}

export function updateProductline(data) {
  return request({
    url: 'api/productline/update',
    method: 'post',
    data
  })
}

export function deleteProductline(id) {
  return request({
    url: 'api/productline/delete?id=' + id,
    method: 'get'
  })
}

export default { queryProductline, getProductline, getAllProductline, createProductline, updateProductline, deleteProductline }
