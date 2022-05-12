variable "gcp-location" {
  type = string
}
variable "environment-name" {
  type = string
}
variable "service-account-email" {
  type = string
}
variable "application-name" {
  type = string
}

variable "max-scale" {
  type    = string
  default = "10"
}

variable "sql-instance-connection-name" {
  nullable = true
  default  = null
  type     = string
}

variable "environment-variables" {
  default = {}
  type    = map(string)
}

variable "environment-secrets" {
  default = {}
  type    = map(string)
}
